using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_3
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
    
        public void BeReadyForLesson() 
        {
            Console.WriteLine("I am ready for the lesson");
        }
    }
}
