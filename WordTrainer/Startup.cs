using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WordTrainer.Models;

namespace WordTrainer
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration, IWebHostEnvironment env)
        {
            Configuration = configuration;
            Configuration = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json")
                .Build();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            var str = Configuration.GetValue<string>("WordsTrainerDatabaseTest:ConnectionString");
            services.AddDbContext<ApplicationContext>(options => options.UseSqlServer(str));
            services.AddTransient<IWordRepository, EFWordRepository>();
            services.AddTransient<UrlHelperFactory>();
            // services.AddSingleton<IWordRepository, FakeRepository>();
            services.AddMvc(option => option.EnableEndpointRouting = false);
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.Use(async (context, next) =>
            {
                context.Response.Headers.Add("X-Powered-By", "none");
                context.Response.Headers.Add("X-Frame-Options", "DENY");
                context.Response.Headers.Add("X-Xss-Protection", "1; mode=block");
                // Content-Security-Policy
                await next();
            });

            app.UseStatusCodePages();    
            app.UseStaticFiles();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: null,
                    template: "{controller}/{action}/{letter?}");

                routes.MapRoute(
                    name: null,
                    template:"{controller}/{action}",
                    defaults: new { controller = "Home", action = "Index" });
            });
        }
    }
}
