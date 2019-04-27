using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BethanysPieShop.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace BethanysPieShop
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //AddTransient: Whenever someone asked for IPieRepo, a new MockPieRepo will be returned (new instance).
            //AddSingleton: Same instance will be returned whenver requeted
            //AddScoped: Same intance for same request, different requested will have different instances
            services.AddTransient<IPieRepository, MockPieRepository>();




            //Register framework service
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            //Sequence is important
            app.UseDeveloperExceptionPage();//Display exception page
            app.UseStatusCodePages(); //Display 404 etc
            app.UseStaticFiles(); //route for static file in wwwroot
            app.UseMvcWithDefaultRoute(); //use MVC default route
        }
    }
}
