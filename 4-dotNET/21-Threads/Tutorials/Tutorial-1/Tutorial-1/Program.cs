using System;
using System.Threading;

namespace Tutorial_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread = new Thread(WriteDot);
            thread.Start();

            Console.WriteLine("Main Isalive: " + thread.IsAlive);
            Console.WriteLine("Main Isalive: " + thread.IsAlive);


            try
            {
                for (int i = 0; i < 1000; i++)
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    //Console.Write("-");
                    Thread.Sleep(1);

                    if (i > 500)
                    {
                        thread.Join();
                    }

                }

                thread.Abort();
               

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void WriteDot()
        {
            try
            {
                for (int i = 0; i < 1000; i++)
                {
                    Console.BackgroundColor = ConsoleColor.Magenta;

                    Console.Write(".");
                    Thread.Sleep(1);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
