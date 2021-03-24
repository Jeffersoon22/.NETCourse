using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tutorial_2.MIddleware
{
    public class RoutingMiddleware
    {
        private readonly RequestDelegate _next;

        Dictionary<string, string> routes = new Dictionary<string, string> 
        {
            {"/index","<h1>Home page</h1>" },
            {"/secret","<h1>Secret opened</h1>" },
        };

        public RoutingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            var path = context.Request.Path.Value;

            if (routes.ContainsKey(path))
            {
                context.Response.StatusCode = 200;
                await context.Response.WriteAsync(routes[path]);
            }
            throw new PageNotFoundException();
        }
    }
}
