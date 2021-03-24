using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace practice_1
{
    public class Startup
    {
       public void ConfigureServices(IServiceCollection services)
        {
        }

       public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.Map("/home/dog", Dog);
            app.Map("/home/cat", Cat);
            app.Map("", Home);

        }
        private static void Home(IApplicationBuilder app)
        {
            app.Run(async (context) => {

                await context.Response.WriteAsync(@"<h1 style='color: red; '>Animal Not Found!</h1>");
            });
        }

        

        private static void Dog(IApplicationBuilder app)
        {
            app.Run(async (context) => {

                await context.Response.WriteAsync(@"<h1 style='color: blue; '>It is a dog</h1>");
            });
        }



        private static void Cat(IApplicationBuilder app)
        {
            app.Run(async (context) => {

                await context.Response.WriteAsync(@"<h1 style='color: blue; '>It is a cat</h1>");
            });
        }





    }
}
