using System;
using System.Threading;

namespace Practice_3
{
    class Program
    {
        private static int[] array = new int[20];

        static void Main(string[] args)
        {

            Random random = new Random();
            Console.WriteLine("I create array of 20 elemets:");
            for (int i=0;i<array.Length; i++)
            {
                array[i] = random.Next(-100, 100);
            }

            foreach (var num in array)
            {
                Console.Write("{0}  ", num);
            }
            Console.WriteLine();
            Console.WriteLine("Processing...");

            Thread first = new Thread(MultPositives);
            Thread second = new Thread(ShowNegatives);

            first.Start();
            second.Start();
            Console.ReadKey();
        }


        static void ShowNegatives()
        {
            foreach(var num in array)
            {
                if (num < 0)
                {
                    Console.WriteLine("Negative number is {0}", num);
                    Thread.Sleep(50);
                }
                
            }
        }


        static void MultPositives()
        {
            foreach(var num in array)
            {
                if(num >= 0)
                {
                    Console.WriteLine(num * 100);
                    Thread.Sleep(50);
                }
            }
        }


    }
}
