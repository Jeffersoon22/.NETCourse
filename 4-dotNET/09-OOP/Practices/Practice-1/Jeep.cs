using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_1
{
    public class Jeep : Car
    {
        public Jeep(double currentspeed)
        {  
            this.CurrentSpeed = currentspeed;
        }

        public override void GetCurrentSpeed(double updatedSpeed)
        {
            if (CurrentSpeed > MaxSPeed)
            {
                Console.WriteLine("Current speed of Jeep:" + MaxSPeed);
            }
            else
            {
                Console.WriteLine("Current speed of Jeep:" + CurrentSpeed);

            }
        }
    }
}