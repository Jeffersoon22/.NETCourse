using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_2
{

    class Student : Person
    {

        public int CourseNumber;
        public Student()
        {

        }
        public Student(string name, string passportid, int coursenumber)
        {
            this.Name = name;
            this.PassportId = passportid;
            this.CourseNumber = coursenumber;
        }
        


        public override void GetInfo()
        {
            Console.WriteLine($"Name: {Name},  PassportId: {PassportId},  Coursenumber: {CourseNumber}");

        }
    }
}
