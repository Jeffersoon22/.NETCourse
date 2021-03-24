using System;

namespace Divisible5And10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input number: ");
            string stringNum = Console.ReadLine();

            int number;
            var isNumber = int.TryParse(stringNum, out number);

            Console.WriteLine();

            if (!isNumber)
            {
                Console.WriteLine("Incorect fotmat!");
                Console.ReadKey();
            }

            else if (number % 5 != 0)
            {
                Console.WriteLine("Number is not divisible by 5 or 10");
            }

            else if (number % 10 == 0 && number > 0)
            {
                Console.WriteLine("Number is divisible by 5 and 10");
            }

            else
            {
                Console.WriteLine("Number is divisible by 5 only");
            }

            Console.ReadKey();
            
        }
    }
}
