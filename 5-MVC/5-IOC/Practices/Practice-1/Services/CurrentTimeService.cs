using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice_1.Services
{
    public class CurrentTimeService : ITimeService
    {
        public string GetTime()
        {
            DateTime time = DateTime.Now;
            return $"Hour: {time.Hour} \nMinute: {time.Minute}\nSecond: {time.Second}";
        }
    }
}
