using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using CourseFantastic.Parse;

namespace CourseFantastic.Api
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            // Set up configuration sources.
            var builder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration { get; set; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Add framework services.
            services.AddMvc();

            //services.AddScoped<Domain.Model.IGenericRepository<Domain.Model.Person>, Domain.Repo.FakePersonRepository>(Controllers.FakePersonRepositoryFactory.Create);
            services.AddScoped<Application.Users.PeopleApplicationService, Application.Users.PeopleApplicationService>();
            services.AddScoped<Domain.Model.IGenericRepository<Domain.Model.Person>, Parse.Repositories.ParsePersonRepo>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            app.UseIISPlatformHandler();

            app.UseStaticFiles();

            app.UseMvc();

            AppInit.Initialize();
        }

        // Entry point for the application.
        public static void Main(string[] args) => WebApplication.Run<Startup>(args);
    }
}
