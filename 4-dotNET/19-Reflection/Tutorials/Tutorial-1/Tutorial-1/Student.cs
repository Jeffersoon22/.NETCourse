using System;
using System.Collections.Generic;
using System.Text;

namespace Tutorial_1
{
    class Student
    {
        private string StudentsSecret = "I have a secret";
        public int Number { get; set; }
        public string Name { get; set; }


        public void ShowSecret()
        {
            Console.WriteLine(StudentsSecret);
        }
        public void DisplayDate(string displayParam)
        {
            Console.WriteLine($"Name: {Name} , Number: {Number}");
        }

    }
}
