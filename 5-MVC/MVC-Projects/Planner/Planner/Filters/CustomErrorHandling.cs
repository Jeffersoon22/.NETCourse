using Microsoft.AspNetCore.Mvc.Filters;
using NLog;

namespace Planner.Filters
{
    public class CustomErrorHandling : IExceptionFilter
    {
        private readonly NLog.ILogger _logger;

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
