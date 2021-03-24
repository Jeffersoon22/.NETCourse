using System;

namespace Sum_of_two_number_variables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input first integer: ");
            string firstNum = Console.ReadLine();
            int firstNumInt = Convert.ToInt32(firstNum);

            Console.Write("Input second integer: ");
            string secondNum = Console.ReadLine();
            int secondNumInt = Convert.ToInt32(secondNum);
            Console.WriteLine();
            var sumOfnums = firstNumInt + secondNumInt;
            Console.Write($"{firstNum} + {secondNum} = {sumOfnums}");
            Console.ReadKey();
        }
    }
}
