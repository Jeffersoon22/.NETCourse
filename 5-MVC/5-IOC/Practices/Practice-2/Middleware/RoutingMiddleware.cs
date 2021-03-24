using Microsoft.AspNetCore.Http;
using Practice_2.Exceptions;
using Practice_2.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice_2.Middleware
{
    public class RoutingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly IGenerator _generate;




        public RoutingMiddleware(RequestDelegate next, IGenerator generate)
        {
            _next = next;
            _generate = generate;
        }



        public async Task Invoke(HttpContext context, IGenerator time)
        {
            Dictionary<string, string> routes = new Dictionary<string, string>
            {
                {"/", UrlGenerate(context)}
            };


            var path = context.Request.Path.Value;

            if (routes.ContainsKey(path))
            {
                context.Response.StatusCode = 200;
                await context.Response.WriteAsync(routes[path]);
                await _next.Invoke(context);
            }
            
        }

        public string UrlGenerate(HttpContext context)
        {
            string value = context.Request.Query.FirstOrDefault(q => q.Key == "select").Value.ToString();

            if (value == "1")
            {
                return $"<p style='color:blue'>Random string: {_generate.GenerateString(10)}</p>";
            }
            else if (value == "2")
            {
                return $"<p style='color:blue'>Negative integer: {_generate.GenerateNegativeIntegerNumber()}</p>";
            }
            else if (value == "3")
            {
                return $"<p style='color:blue'>Positive integer: {_generate.GeneratePositiveIntegerNumber()}</p>";
            }
            else
            {
                return string.Empty;
            }
        }
    }
}
