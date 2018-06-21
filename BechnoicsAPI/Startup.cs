using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BechnoicsAPI.Models;
using BechnoicsAPI.Services;
using BechnoicsAPI.ViewModels;
using Mapster;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace BechnoicsAPI
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
            services.AddMvc();

            services.AddSingleton<IEmployeeService, EmployeeMemoryService>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            TypeAdapterConfig<Employee, EmployeeViewModel>.NewConfig()
                            .Map(dest => dest.Name, src => src.FirstName + " " + src.FamilyName);

            app.UseMvc();
        }
    }
}
