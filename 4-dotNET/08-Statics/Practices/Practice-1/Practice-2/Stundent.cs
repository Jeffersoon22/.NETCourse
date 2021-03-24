using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_2
{
    public class Stundent
    {
        public static int counter = 0;
        public int Age { get; set; }
        public string Name { get; set; }

        public Stundent(string name, int age)
        {
            this.Name = name;
            this.Age = age;
            counter++;
        }
    }
}
