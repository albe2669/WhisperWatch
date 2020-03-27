using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;

using Classes.Webserver.Models;
using Classes.Webserver.Data.MessageContext;
using Classes.Webserver.Data.SchoolContext;

namespace MQTT.Webserver.Subscriber
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddDbContext<MessageContext>(opt =>
                        opt.UseSqlServer("Data Source=DESKTOP-I95SJQK;Initial Catalog=WhisperWatch;Integrated Security=True"));
                    services.AddDbContext<SchoolContext>(opt =>
                        opt.UseSqlServer("Data Source=DESKTOP-I95SJQK;Initial Catalog=WhisperWatch;Integrated Security=True"));
                    services.AddHostedService<Worker>();
                });
    }
}
