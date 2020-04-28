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
using System.Text.RegularExpressions;

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
                'r': {'type': 'integer'},
                'c': {
                    'type': 'array',
                    's': 'int',
                    'm': 'string'
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
                JObject roomMessageParsed = JObject.Parse(message.Body);

                IServiceScope scope = _serviceScopeFactory.CreateScope();
                SchoolContext _context = scope.ServiceProvider.GetRequiredService<SchoolContext>();
                RoomMessage roomMessage = new RoomMessage();

                if (!roomMessageParsed.IsValid(schema))
                {
                    _logger.LogInformation("JSON didnt fit the schema, therefore returning");
                    return;
                }
      
                _logger.LogInformation("Json was valid, creating room message and saving it");

                JArray clients = (JArray)roomMessageParsed["c"];

                roomMessage.Clients = clients.Count();
                roomMessage.PublisherId = "deprecated";
                roomMessage.RoomId = roomMessageParsed.GetValue("r").ToObject<long>();

                foreach (JObject client in clients)
                {
                    Device device = new Device();
                    device.MacAdress = Regex.Replace(client.GetValue("m").ToObject<string>(), ".{8}", "$0:");
                    device.SignalStrength = client.GetValue("s").ToObject<int>();
                    device.RoomMessage = roomMessage;

                    _context.Devices.Add(device);
                }

                _context.RoomMessages.Add(roomMessage);
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
