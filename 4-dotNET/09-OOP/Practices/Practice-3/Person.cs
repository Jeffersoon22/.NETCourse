using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_3
{
    public class Person
    {

        public string Name { get; set; }
        public string PassportId { get; set; }

        public Person()
        {

        }

        public Person(string name, string passportid)
        {
            Name = name;
            PassportId = passportid;
        }
        public virtual void GetInfo()
        {
            Console.WriteLine($"Name: {Name}, PassportId: {PassportId}");
        }


    }
}
