using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Practice_2.Middleware;
using Practice_2.Services;

namespace Practice_2
{
    public class Startup
    {
         public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IGenerator, RandomGenerator>();
        }

        
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseMiddleware<RoutingMiddleware>();


            string menu = "<br>Menu:<br><br>1. Random string<br>2. Negative integer<br>3. Positive integer";

            app.Run(context => context.Response.WriteAsync(menu));

        }
    }
}
