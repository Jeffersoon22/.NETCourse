using System;

namespace Practice_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person bob = new Person("Bob", "UA162739");
            Student alex = new Student("Alex", "UA096701", 3);
            StudentInfo info = new StudentInfo("4, Ramdas Rd, Gujarat");

            bob.GetInfo();
            alex.GetInfo();
            info.GetInfo();
            Console.ReadKey();
        }
    }
}
