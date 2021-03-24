using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_2
{
    class StudentInfo : Student
    {
        private string Address;

        public StudentInfo(string address)
        {
            Address = address;
        }
        public override void GetInfo()
        {
            Console.WriteLine($"Student Address: {Address}");
        }
    }
}
