using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_1
{
    public class Bike
    {
        public string Name { get; set; }
        public int CurrentSpeed { get; set; }

        public Bike(string name, int currentSpeed)
        {
            Name = name;
            CurrentSpeed = currentSpeed;
        }

    }
}
