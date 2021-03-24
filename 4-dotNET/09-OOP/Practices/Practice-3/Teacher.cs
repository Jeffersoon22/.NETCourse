using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_3
{
    class Teacher : Person
    {
        public int ExperienceInLessons;

        public void GoToClasses() 
        {
            Console.WriteLine("I am going to class");
        }
        public void Explain() 
        {
            Console.WriteLine("Explanation begins");
        }
        public void IncreaseExperience() 
        {
            ExperienceInLessons += 1;
        }
        public void GetInfo() 
        {
            Console.WriteLine($"Name: Mr {Name}, PassportId: {PassportId}, ExperienceInLessons: {ExperienceInLessons}");
        }


        public Teacher(string name, string passportid, int experienceinlessons)
        {
            this.Name = name;
            this.PassportId = passportid;
            this.ExperienceInLessons = experienceinlessons;

            
        }
    }
}
