using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tutorial_1.Filters
{
    public class InternetExplorerFilterAttribute : IResourceFilter
    {
        private const string ieAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64; Trident/7.0; rv:11.0) like Gecko";
        public void OnResourceExecuting(ResourceExecutingContext context)
        {
            var userAgent = context.HttpContext.Request.Headers["User-Agent"].FirstOrDefault();
            if (!string.IsNullOrWhiteSpace(userAgent) && userAgent.Contains(ieAgent))
            {
                context.Result = new ViewResult() { ViewName = "Error" };
            }
        }
        public void OnResourceExecuted(ResourceExecutedContext context)
        {
            
        }

        
    }
}
