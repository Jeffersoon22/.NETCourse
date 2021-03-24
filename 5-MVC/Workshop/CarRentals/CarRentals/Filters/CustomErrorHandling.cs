using Microsoft.AspNetCore.Mvc.Filters;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentals.Filters
{
    public class CustomErrorHandling : IExceptionFilter
    {
        private readonly ILogger _logger;

        public CustomErrorHandling()
        {
            _logger = LogManager.GetCurrentClassLogger();
        }
        public void OnException(ExceptionContext context)
        {
            _logger.Error(context.Exception, "Error from filter");
        }
    }
}
