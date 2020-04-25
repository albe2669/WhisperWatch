using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.SpaServices.ReactDevelopmentServer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;


using Microsoft.AspNetCore.Http;
using Classes.Webserver.Models;
using MQTT.Webserver.Subscriber;

using Classes.Webserver.Data.SchoolContext;
using Classes.Webserver.Data.MessageContext;

namespace Core.Webserver
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<SchoolContext>(opt =>
                opt.UseSqlServer(
                    Configuration.GetConnectionString("SchoolContextConnection"),
                    b => b.MigrationsAssembly("Core.Webserver")
                ));

            services.AddDbContext<MessageContext>(opt =>
                opt.UseSqlServer(
                    Configuration.GetConnectionString("MessageContextConnection"),
                    b => b.MigrationsAssembly("Core.Webserver")
                ));

            services.AddControllers();
            services.AddHostedService<Worker>();
            services.AddSpaStaticFiles(configuration =>
            {
                configuration.RootPath = "FrontEnd/public";
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            // SPA stuff
            app.UseSpaStaticFiles();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseSpa(spa =>
            {
                spa.Options.SourcePath = "FrontEnd";

                /*if (env.IsDevelopment())
                {
                    spa.UseProxyToSpaDevelopmentServer("http://127.0.0.1:5000");
                }*/
            });
        }
    }
}
