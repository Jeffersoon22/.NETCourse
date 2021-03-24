using System;
using System.Collections.Generic;
using System.Text;

namespace Tutorial_2
{
    public class TemperatureValidator
    {
        private const int MinTemperature = -60;
        private const int MaxTemperature = 60;
        public int Temperature { get; set; }

        public TemperatureValidator(int temperature)
        {
            if(IsTempInrange(temperature))
            {
                throw new IncredibleTemperatureException("Temperature is out of range ");
            }
            
            Temperature = temperature;
        }

            private bool IsTempInrange(int temp)
            {
                return temp < MinTemperature || temp > MaxTemperature;
            }
        }

}
