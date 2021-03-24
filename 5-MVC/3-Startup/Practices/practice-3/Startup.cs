using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace practice_3
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

            app.MapWhen((context) => context.Request.Query.FirstOrDefault(q => q.Key == "number").Value.ToString().Length > 0, Calculate);
            app.Map("", Home);

        }




        private static void Calculate(IApplicationBuilder app)
        {
            app.Run(async (context) => {

                var numberValue = context.Request.Query.FirstOrDefault(q => q.Key == "number").Value.ToString();
                bool isNumDouble = double.TryParse(numberValue, out double numDub);

                if(isNumDouble)
                {
                    await context.Response.WriteAsync($"<h2 style='font-family:verdana;'>n={numDub}, n*100={numDub*100}</h2> ");
                }
                else
                {
                    await context.Response.WriteAsync(@"<h2 style='font-family:verdana; '>Value is not a number</h2>");
                }
            });
        }




        private static void Home(IApplicationBuilder app)
        {
            app.Run(async (context) => {

                await context.Response.WriteAsync(@"<h1 style='font-family:verdana; '>Multiply on 100 app</h1>"); 
            });
        }
    }
}
