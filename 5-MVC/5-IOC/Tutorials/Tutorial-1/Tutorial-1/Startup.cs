using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
namespace Tutorial_1
{
    public class Startup
    {
        private IServiceCollection _service;
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            _service = services;
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
                    await context.Response.WriteAsync(GetServices(_service));
                });
            });
        }
        private string GetServices(IServiceCollection services)
        {
            ServiceDescriptor service = services.FirstOrDefault();
            var sBuilder = new StringBuilder();
            sBuilder.AppendLine($"Guid: {service.ServiceType.GUID}\n");
            sBuilder.AppendLine($"Namespace: {service.ServiceType.Namespace}\n");
            sBuilder.AppendLine($"Name: {service.ServiceType.Name}\n");
            sBuilder.AppendLine($"Fullname: {service.ServiceType.FullName}\n");
            sBuilder.AppendLine($"Assembly.Fullname: {service.ServiceType.Assembly.FullName}\n");
            return sBuilder.ToString();
        }
    }
}