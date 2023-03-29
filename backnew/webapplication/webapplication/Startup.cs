using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webapplication
{
    public class Startup
    {
        
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
        }

      
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(

                    "default",
                    "{controller=home}/{action=index}/{id?}"
                    );

                //endpoints.MapControllerRoute(
                //    name:"About",
                //    pattern:"about-us",
                //    defaults:new {controller="Home", action="About"}
                //    );

                

                //endpoints.MapControllerRoute(
                //    name:"Product",
                //    pattern:"product",
                //    defaults: new {controller="Product", action="detail" }

                //    );

                //endpoints.MapControllerRoute(
                //    "deafulr",
                //    "{controller=home}/{action=index}/{id?}");

               
            });
        }
    }
}
