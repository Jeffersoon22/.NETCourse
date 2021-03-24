using System;
using System.Collections.Generic;
using System.Text;

namespace Tutorial_2
{
    public class Animals
    {
        public static int NumberOfLegs = 4;
        public string Name { get; set; }
        public string Species { get; set; }

        static Animals()
        {
            Console.WriteLine("NumberOfLeg: " + NumberOfLegs);
            Console.WriteLine("Static constructor running");
        }
        public Animals()
        {
            Console.WriteLine("Parameterless constructor running");
        }

        public Animals(string name)
        {
            Console.WriteLine("Name constructor running");
            Name = name;
        }
    }
}


