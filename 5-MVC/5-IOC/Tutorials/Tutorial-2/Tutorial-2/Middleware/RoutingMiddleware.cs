using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tutorial_2.Services;

namespace Tutorial_2.Middleware
{
    public class RoutingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly IBrandService _brandService;



       

        public RoutingMiddleware(RequestDelegate next, IBrandService brandService)
        {
            _next = next;
            _brandService = brandService;
        }

        public async Task Invoke(HttpContext context)
        {

            Dictionary<string, string> routes = new Dictionary<string, string> {
                {"/index", "<h1>Home page</h1>"},
                {"/secret", "<h1>Secret opened</h1>"},
                {"/", GetBrands(context)}
            };



            var path = context.Request.Path.Value;

            if (routes.ContainsKey(path))
            {
                context.Response.StatusCode = 200;
                await context.Response.WriteAsync(routes[path]);
            }

            throw new PageNotFoundException();
        }


        private string GetBrands(HttpContext context)
        {
            var brandList = _brandService.GetBrands();

            var sBuilder = new StringBuilder();

            sBuilder.AppendLine("--Brand List--");

            brandList.ToList().ForEach(x => sBuilder.AppendLine($"Brand: {x.Name}"));
            sBuilder.AppendLine();
            sBuilder.AppendLine($"GUID fromRoutingMiddleware: {_brandService.Guid}");
            sBuilder.AppendLine($"Guid from ErrorHandlingMiddleware: {context.Items["Guid"]}");

            return sBuilder.ToString();
        }
    }
}
