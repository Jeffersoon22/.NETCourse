using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_1
{

    public class Car
    {
        public readonly double MaxSPeed = 200;
        public double CurrentSpeed { get; set; }
        
        public Car()
        {

        }


        public Car(double currentSpeed)
        {
            CurrentSpeed = currentSpeed;
        }


        public virtual void GetCurrentSpeed(double updatedSpeed)
        {

            Console.WriteLine($"Update speed: {updatedSpeed}");
            if (CurrentSpeed > MaxSPeed)
            {
                Console.WriteLine($"Current speed of car: {MaxSPeed}");
            }
            else
            {
                Console.WriteLine($"Current speed of car: {CurrentSpeed}");
            }
        }

    }
}
