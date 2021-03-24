using System;
using System.Collections.Generic;
using System.Text;

namespace Tutorial_1
{
    public class Battery
    {
        public Battery(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
        public int CurrentCharge { get; set; } = 100;
    }
}
