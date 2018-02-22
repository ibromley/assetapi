using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

using AssetApi.Models;

namespace AssetApi
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
            services.AddDbContext<AssetContext>(opt => opt.UseInMemoryDatabase("AssetList"));
    
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            
            // Path to json file in local storage
            String path = System.IO.Path.Combine(Environment.CurrentDirectory.ToString(), "DataSources/test.json");

            // Read all text into memory
            String json = System.IO.File.ReadAllText(path);
             
            // Seed in EF in memory database 
            Seeder.writeJson(json ,app.ApplicationServices);

            app.UseMvc();
        }
    }
}
