using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tutorial_1.Logger
{
    public class CarLogger : ICarLogger
    {
        private readonly NLog.Logger _logger = LogManager.GetCurrentClassLogger();
        public void LogError(Exception ex, string message)
        {
            _logger.Error(ex, message);
        }

        public void LogInfo(string message)
        {
            _logger.Info( message);
        }

        public void LogWarning(string message)
        {
            _logger.Warn(message);
        }
    }
}
