using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.Text;


using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

// MQTT
using MQTTnet;
using MQTTnet.Client;
using MQTTnet.Client.Options;
using MQTTnet.Client.Disconnecting;
using MQTTnet.Client.Connecting;
using MQTTnet.Client.Receiving;

// Models
using Classes.Webserver.Models;
using Classes.Webserver.Data.MessageContext;
using Classes.Webserver.Data.SchoolContext;

// JSON
using Newtonsoft.Json.Schema;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace MQTT.Webserver.Subscriber
{
    public class Worker : BackgroundService
    {
        // Worker Service
        private readonly ILogger<Worker> _logger;
        private readonly IServiceScopeFactory _serviceScopeFactory;

        // MQTT
        private MqttFactory factory;
        private IMqttClient client;
        private IMqttClientOptions options;

        // JSON
        private readonly string jsonSchema = @"{
            'description': 'A Room Message',
            'type': 'object',
            'properties': {
                'client_id': {'type': 'string'},
                'room_id': {'type': 'integer'},
                'client_count': {'type': 'integer'},
                'clients': {
                    'type': 'array',
                    'signal_strength': 'int',
                    'mac_address': 'string'
                },
             }
        }";

        public Worker(ILogger<Worker> logger, IServiceScopeFactory serviceScopeFactory)
        {
            _logger = logger;
            _serviceScopeFactory = serviceScopeFactory;

            factory = new MqttFactory();

            options = new MqttClientOptionsBuilder()
                .WithClientId("WebserverSubscriber")
                .WithTcpServer("192.168.1.200") // TODO: Configure this to use some sort of configuration file
                .Build();

            client = factory.CreateMqttClient();
        }
        
        private async void InsertMessage(Message message)
        {
            IServiceScope scope = _serviceScopeFactory.CreateScope();

            MessageContext messageContext = scope.ServiceProvider.GetRequiredService<MessageContext>();
            messageContext.Add(message);
            await messageContext.SaveChangesAsync();
        }

        private async void OnConnect(MqttClientConnectedEventArgs e)
        {
            _logger.LogInformation("Succesfully connected to server");

            // Subscribe to all topics
            // TODO: Probably change the topic to something more appropriate
            await client.SubscribeAsync(new TopicFilterBuilder().WithTopic("#").Build());

            _logger.LogInformation("Succesfully subscribed to all topics");
        }

        private void OnMessage(MqttApplicationMessageReceivedEventArgs e)
        {
            _logger.LogInformation("Recieved message");
            Message message = new Message();
            message.Body = Encoding.UTF8.GetString(e.ApplicationMessage.Payload);
            message.Topic = e.ApplicationMessage.Topic;

            InsertMessage(message);

            if(message.Topic == "whisperwatch/roommessage")
            {
                parseJson(message);
            }
        }

        private async void parseJson(Message message)
        {
            JSchema schema = JSchema.Parse(jsonSchema);

            try
            {
                IServiceScope scope = _serviceScopeFactory.CreateScope();
                SchoolContext _context = scope.ServiceProvider.GetRequiredService<SchoolContext>();
                RoomMessage roomMessage = new RoomMessage();
                JObject roomMessageParsed = JObject.Parse(message.Body);

                if (!roomMessageParsed.IsValid(schema))
                {
                    _logger.LogInformation("JSON didnt fit the schema, therefore returning");
                    return;
                }
      
                _logger.LogInformation("Json was valid, creating room message and saving it");

                roomMessage.PublisherId = roomMessageParsed.GetValue("client_id").ToString();
                roomMessage.RoomId = roomMessageParsed.GetValue("room_id").ToObject<long>();
                roomMessage.Clients = roomMessageParsed.GetValue("client_count").ToObject<long>();

                _context.RoomMessages.Add(roomMessage);
                await _context.SaveChangesAsync();

                JArray clients = (JArray)roomMessageParsed["clients"];
                foreach (JObject client in clients)
                {
                    Device device = new Device();
                    device.MacAdress = client.GetValue("mac_address").ToObject<string>();
                    device.SignalStrength = client.GetValue("signal_strength").ToObject<int>();
                    device.RoomMessage = roomMessage;

                    _context.Devices.Add(device);
                }

                await _context.SaveChangesAsync();
            }
            catch (JsonReaderException jex)
            {
                _logger.LogInformation("Json was not valid");
            }
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {

            client.UseDisconnectedHandler(async e =>
            {
                _logger.LogInformation("Disconnected from server, waiting 5 seconds and then retrying");
                await Task.Delay(TimeSpan.FromSeconds(5), stoppingToken);

                try
                {
                    await client.ConnectAsync(options, stoppingToken);
                }
                catch
                {
                    _logger.LogInformation("Failed to reconnect");
                }
            });

            client.UseApplicationMessageReceivedHandler(OnMessage);
            client.UseConnectedHandler(OnConnect);

            await client.ConnectAsync(options, stoppingToken);
        }
    }
}
