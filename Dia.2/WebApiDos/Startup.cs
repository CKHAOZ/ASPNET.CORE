using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using WebApiDos.Infrastructure;
using Serilog;
using WebApiDos.Domain;
using WebApiDos.Services;

namespace WebApiDos
{
    public class Startup
    {
        public IConfigurationRoot Configuration { get; }

        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true, reloadOnChange: true)
                .AddEnvironmentVariables();

            Configuration = builder.Build();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<SmtpConfiguration>(Configuration.GetSection("SmtpConfiguration"));

            services.AddMemoryCache();
            
            services.AddSession(options =>
            {
                options.CookieName = ".aspnetcore.session";
                options.IdleTimeout = TimeSpan.FromMinutes(30);
                options.CookieSecure = CookieSecurePolicy.SameAsRequest;
            });

            services.AddDbContext<LibraryContext>(
                options => options.UseSqlServer(Configuration.GetConnectionString("ConnectionStrings"))
            );

            services.AddScoped<ICategoryRepository, DbCategoryRepository>();
            services.AddScoped<IBookRepository, DbBookRepository>();

            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            var logger = new LoggerConfiguration()
                                .ReadFrom.Configuration(Configuration)
                                .CreateLogger();
                                    Log.Logger = logger;
                                    loggerFactory.AddSerilog();

            logger.Information("Logger configurado");
            logger.Information("MVC Configurado");

            app.UseStaticFiles();

            app.UseSession();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller}/{action}");
            });

        }
    }
}
