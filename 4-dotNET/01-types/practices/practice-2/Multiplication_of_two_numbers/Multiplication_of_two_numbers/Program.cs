using System;

namespace Multiplication_of_two_numbers
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

            var Multiplication = firstNumber * secondNumber;
            Console.WriteLine();
            Console.WriteLine($"Result: {Multiplication}");

            long longMultiplication = (long)Multiplication;
            bool isGreater = longMultiplication > 10;

            Console.WriteLine($"Result is greater than 10: {isGreater}");
            Console.ReadKey();

        }
    }
}