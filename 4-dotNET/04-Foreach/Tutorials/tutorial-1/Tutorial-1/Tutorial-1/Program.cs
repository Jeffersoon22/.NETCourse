using System;

namespace Tutorial_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("input first number: ");
            string firstInput = Console.ReadLine();
            bool isFirstValid = int.TryParse(firstInput, out int first);

            if (!isFirstValid)
            {
                Console.Write("Incorect format");
                Console.ReadKey();
                return;
            }


            Console.Write("input second number: ");
            string secondInput = Console.ReadLine();
            bool isSecondValid = int.TryParse(secondInput, out int second);

            if (!isSecondValid) 
            {
                Console.Write("Incorect format");
                Console.ReadKey();
                return;
            }




            if (first >= second)
            {
                Console.WriteLine("Range can not be calculated");
                Console.ReadKey();
                return;
            }

            for (var i = first + 1; i < second; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
} 
