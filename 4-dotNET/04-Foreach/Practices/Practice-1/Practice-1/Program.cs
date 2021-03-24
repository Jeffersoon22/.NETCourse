using System;

namespace Practice_1
{
    class Program
    {
        static void Main(string[] args)
        {

            bool sentence = true;
            int counter = 0;

            while(sentence)
            {
                Console.WriteLine("Input number: ");
                string stringNum = Console.ReadLine();
                int number;
                bool isNum = int.TryParse(stringNum, out number);

                if (!isNum)
                { 
                    continue;
                }

                else if(number != 0)
                {
                    counter += 1;
                }
                else
                {
                    Console.WriteLine($"Count of entered numbers before zero: {counter}");
                    sentence = false;
                    Console.ReadKey();
                }
                

            }
        }
    }
}