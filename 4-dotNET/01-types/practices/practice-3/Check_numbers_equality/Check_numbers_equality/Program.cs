using System;

namespace Check_numbers_equality
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input first number: ");
            string firstNumberString = Console.ReadLine();
            double firstNumber = Convert.ToDouble(firstNumberString);

            Console.Write("Input second number: ");
            string secondNumberString = Console.ReadLine();
            double secondNumber = Convert.ToDouble(secondNumberString);

            bool isEqual = firstNumber == secondNumber;

            Console.WriteLine();

            Console.WriteLine($"Numbers are equal: {isEqual}");
            Console.ReadKey();

        }
    }
}
