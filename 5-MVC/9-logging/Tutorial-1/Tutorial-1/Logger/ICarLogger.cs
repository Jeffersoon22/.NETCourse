using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tutorial_1.Logger
{
    public interface ICarLogger
    {
        void LogError(Exception ex, string message);
        void LogWarning(string message);
        void LogInfo(string message);

    }
}
