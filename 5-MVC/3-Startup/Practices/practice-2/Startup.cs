using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace practice_2
{
    public class Startup
    {
        

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }



        public IConfiguration Configuration { get; }



        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
        }

         public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();


            var books = new List<Book>()
            {
                new Book("William Shakespeare","Romeo and Juliet",1597),
                new Book("Anton Chekhov","Three Sisters",1900)
            };
            


            string outputString =
                @"<table class='table' style='border: 1px solid;'>" +
                @"<thead><tr><th>Name</th><th>Author</th><th>Release year</th></thead>" +
                @"<tbody>";

            foreach (var item in books)
            {
                outputString +=
                    @"<tr>" +
                    $"<td>{item.Name}</td>" +
                    $"<td>{item.Author}</td>" +
                    $"<td>{item.ReleaseYear}</td>" +
                    @"</tr>";
            }




            outputString +=
                @"</tbody></table>";

            app.Run(async context => {
                await context.Response.WriteAsync(outputString);
            });

        }

    }
}
