using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing.Constraints;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace assignment_29
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //register any service need to use it with dependancy injection
            //register MVC built in services  to the containers
            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });
                endpoints.MapGet("/hamada", async context =>
                {
                    await context.Response.WriteAsync("Hello Hamada");
                });

                endpoints.MapControllerRoute(   //first it works with service of dependance injection then we need to add addControllers()
                    name: "default",
                    pattern: "{controller=Movie}/{action=Index}/{id:int?}/{name:alpha?}"  //sigment/sigment  => sigment maybe static,dynamic,mixed
                    //defaults: new { Controller = "Movie", Action = "GetMovie" }   //old way
                    //constraints: new { id = new IntRouteConstraint() }  //old way
                    );
            });
        }
    }
}
