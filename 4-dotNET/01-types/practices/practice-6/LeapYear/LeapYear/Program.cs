using System;

namespace LeapYear
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input year number: ");
            string inputYear = Console.ReadLine();
            int intYear = Convert.ToInt32(inputYear);
            Console.WriteLine();

            bool isLeap = DateTime.IsLeapYear(intYear);
            Console.WriteLine($"{inputYear} is leap year: {isLeap}");
            Console.ReadKey();

        }
    }
}
