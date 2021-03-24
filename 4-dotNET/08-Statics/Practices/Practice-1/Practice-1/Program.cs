using System;

namespace Practice_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input number: ");
            string numberString = Console.ReadLine();
            int number = int.Parse(numberString);
            Console.WriteLine();
            Console.WriteLine($"Factorial if Given Number is : {Factorial(number)}");
            Console.ReadKey();
        }

        public static long Factorial(long a)
        {
            long factorial = 1;
            for (int i = 1; i <= a;i++)
            {
                factorial=factorial*i;
            }
            return factorial;
        }

    }
}
