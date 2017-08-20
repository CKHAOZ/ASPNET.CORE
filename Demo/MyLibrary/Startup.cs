using System;
using System.IO;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Cors;
using Microsoft.AspNetCore.Mvc.Cors.Internal;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.PlatformAbstractions;
using MyLibrary.Domain;
using MyLibrary.Insfrastructure;
using MyLibrary.Insfrastructure.Settings;
using MyLibrary.Services;
using Serilog;
using Swashbuckle.AspNetCore.Swagger;

namespace MyLibrary
{
    public class Startup
    {
        public IConfigurationRoot Configuration { get; }

        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional:false, reloadOnChange:true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional:true, reloadOnChange:true)
                .AddEnvironmentVariables();

            Configuration = builder.Build();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<LibraryContext>(
                options => options.UseSqlServer(Configuration.GetConnectionString("LibraryConn")));

            services.AddIdentity<IdentityUser, IdentityRole>()
                .AddEntityFrameworkStores<LibraryContext>();

            services.Configure<IdentityOptions>(options =>
            {
                options.Password.RequireDigit = true;
                // more configuration options
            });

            //services.AddIdentity<IdentityUser, IdentityRole>()
            //    .AddEntityFrameworkStores<LibraryIdentityDbContext>();

            services.AddScoped<ICategoryRepository, DbCategoryRepository>();
            services.AddScoped<IBookRepository, DbBookRepository>();

            services.Configure<SmtpConfiguration>(Configuration.GetSection("SmtpConfiguration"));

            services.AddCors(options =>
            {
                options.AddPolicy("MyCorsPolicy", builder => builder.WithOrigins("*"));
            });

            services.AddMvc();

            // CORS GLOBAL
            services.Configure<MvcOptions>(options =>
            {
                options.Filters.Add(new CorsAuthorizationFilterFactory("MyCorsPolicy"));
            });

            services.AddMemoryCache();

            services.AddSession(options =>
            {
                options.CookieName = ".aspnetcore.session";
                options.IdleTimeout = TimeSpan.FromMinutes(30);
                options.CookieSecure = CookieSecurePolicy.SameAsRequest;
            });

            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new Info
                {
                    Title = "My Library - API",
                    Description = "Library API services",
                    Contact = new Contact()
                    {
                        Name = "Julio Avellaneda",
                        Email = "julito_gtu@hotmail.com",
                        Url = "www.julitogtu.com"
                    }
                });

                var basePath = PlatformServices.Default.Application.ApplicationBasePath;
                options.IncludeXmlComments(Path.Combine(basePath, "library-api.xml"));
            });
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory, LibraryContext dbContext)
        {
            var logger = new LoggerConfiguration()
                .ReadFrom
                .Configuration(Configuration)
                .CreateLogger();

            Log.Logger = logger;
            loggerFactory.AddSerilog();

            logger.Information("Logger configurado");

            app.UseStaticFiles();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/home/error");
            }

            // Basic CORS
            //app.UseCors(options =>
            //{
            //    options.WithOrigins("*");
            //});

            // CORS with policy
            app.UseCors("MyCorsPolicy");

            app.UseSession();

            app.UseIdentity();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "defaultRoute",
                    template: "{controller}/{action}/{id:int?}",
                    defaults: new { controller = "Home", action = "Index"}
                );
            });

            logger.Information("MVC configurado");

            app.UseSwagger();

            app.UseSwaggerUI(options =>
            {
                options.SwaggerEndpoint("/swagger/v1/swagger.json", "My Library API");
            });

            logger.Information("Swagger configurado");

            if (env.IsDevelopment())
            {
                dbContext.EnsureSeedData();
            }
        }
    }
}
