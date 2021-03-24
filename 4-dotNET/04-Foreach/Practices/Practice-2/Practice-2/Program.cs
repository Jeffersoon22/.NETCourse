using System;
using System.Linq;

namespace Practice_2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool sentence = true;

            while (sentence)
            {
                Console.Write("Input length of array: ");
                string inputNum = Console.ReadLine();
                byte number;
                bool isNum = byte.TryParse(inputNum, out number);

                byte[] array = new byte[number];
                int index = 0;

                if (!isNum)
                {
                    Console.WriteLine();
                    Console.WriteLine("Incorrect format");
                    sentence = false;
                    Console.ReadKey();
                }


                else
                {
                    int inputNumIndex = 1;
                    while (inputNumIndex < number+1)
                    {
                        Console.Write($"Input number {inputNumIndex}: ");
                        string arrayStringItem = Console.ReadLine();
                        byte item;
                        bool isByte = byte.TryParse(arrayStringItem, out item);

                        if (isByte)
                        {
                            array[index++] = item;
                            inputNumIndex++;
                        }

                        else
                        {
                            Console.WriteLine("Number is not a byte! Try again.");
                            continue;
                        }
                    }

                    Console.WriteLine();
                    Console.Write("Array:");

                    foreach (byte item in array)
                    {
                        Console.Write(" "+ item);
                    }

                    Console.WriteLine();
                    byte maxByte = array.Max();
                    Console.WriteLine("The biggest in array: " + maxByte );
                    Console.ReadKey();
                    sentence = false;
                }
            }
        }
    }
}