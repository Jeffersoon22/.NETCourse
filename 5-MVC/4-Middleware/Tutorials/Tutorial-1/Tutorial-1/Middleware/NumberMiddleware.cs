using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
namespace Tutorial_1.Middleware
{
    public class NumberMiddleware
    {
        private readonly RequestDelegate _next;
        public NumberMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task Invoke(HttpContext context)
        {
            var numberQuery = context.Request.Query.FirstOrDefault(x => x.Key == "number");
            var isNumberValid = int.TryParse(numberQuery.Value, out var number);
            if (isNumberValid && Enum.IsDefined(typeof(Numbers), number))
            {
                var result = (Numbers)number;
                Debug.WriteLine($"Result: {result}");
            }
            //var result = (numbers)number;
            //Debug.WriteLine($"Result: {result}");
            await _next.Invoke(context);
        }
    }
}