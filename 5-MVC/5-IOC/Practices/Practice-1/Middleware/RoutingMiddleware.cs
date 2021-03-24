using Microsoft.AspNetCore.Http;
using Practice_1.Exceptions;
using Practice_1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice_1.Middleware
{
    public class RoutingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ITimeService _time;




        public RoutingMiddleware(RequestDelegate next,ITimeService time)
        {
            _next = next;
            _time = time;
        }

        

        public async Task Invoke(HttpContext context, ITimeService time)
        {
            Dictionary<string, string> routes = new Dictionary<string, string>
            {
                {"/", _time.GetTime() }
            };

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
