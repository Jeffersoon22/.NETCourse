using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Tutorial_1.Filters
{
    public class CookiesFilter : IActionFilter
    {
        private const string LastVisitKey = "LastVisit";
        private Stopwatch watch = new Stopwatch();
        public void OnActionExecuting(ActionExecutingContext context)
        {
            var queryPairs = context.HttpContext.Request.Query.ToList();
            foreach (var pair in queryPairs)
            {
                context.HttpContext.Response.Cookies.Append(pair.Key,pair.Value);
            }
            watch.Start();
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            watch.Stop();
            context.HttpContext.Response.Cookies.Append("Elipsed time", watch.Elapsed.ToString());
            context.HttpContext.Response.Cookies.Append(LastVisitKey,DateTime.Now.ToShortTimeString());

        }


    }
}
