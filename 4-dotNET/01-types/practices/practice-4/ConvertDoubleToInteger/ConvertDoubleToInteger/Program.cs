using System;

namespace ConvertDoubleToInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input double number: ");
            string NumberString = Console.ReadLine();
            double Number = Convert.ToDouble(NumberString);

            Console.WriteLine();

            int intNumber = (int)Number;
            Console.WriteLine($"Result: {intNumber}");
            Console.ReadKey();
        }
    }
}
