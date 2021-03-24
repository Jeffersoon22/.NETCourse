using System;

namespace DoubleSum
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

            var sum = firstNumber + secondNumber;
            Console.WriteLine($"rlesult: {sum}");
            Console.WriteLine();

            int intSum = (int)sum;
            bool isEven = intSum % 2 == 0;
            Console.WriteLine($"Result is even number:{isEven} ");

            Console.ReadKey();
        }
    }
}
