using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Tutorial_3
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.Map("/contact", Contact);
            
            app.MapWhen((context) =>
            {
                var value = context.Request.Query.FirstOrDefault(q => q.Key == "name").Value;
                return value == "user";
            }, Secret);
            app.Map("", Home);
        }
        

        private static void Secret (IApplicationBuilder app)
        {
            app.Run(async (context) => { await context.Response.WriteAsync(@"<h1 style='font - family:verdana; color: red'>Secret page!</h1> "); });
        }

        private static void Contact(IApplicationBuilder app)
        {
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("<h1 style ='font-family:verdana;'> Contact us </h1>");
            });
        }

        public static void Home(IApplicationBuilder app)
        {
            app.Run(async (context) => { await context.Response.WriteAsync("<h1 style='font - family:verdana;'>Welcome to home page!</h1>"); });
        }
    }

}
