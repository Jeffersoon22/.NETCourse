using System;

namespace Practice_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Student");
            Student bob = new Student("Bob", "UI096701", 3);
            bob.GetInfo();
            Console.WriteLine();


            Console.WriteLine("Teacher");
            Teacher teacher = new Teacher("Mr Green", "KO723157", 5);
            teacher.GetInfo();
            Console.WriteLine();

            teacher.GoToClasses();
            bob.BeReadyForLesson();
            teacher.Explain();
            teacher.IncreaseExperience();
            Console.WriteLine();

            Console.WriteLine("Teacher");
            teacher.GetInfo();
            Console.ReadKey();
        }
    }
}
