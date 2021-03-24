using System;
using System.Threading;

namespace Practice_4
{
    class Program
    {
        
        static Semaphore semaphore = new Semaphore(2, 2);

        static Thread[] thread = new Thread[5];

        static void Main(string[] args)
        { 
            for (int i = 0; i < 5; i++)
            {
                
                thread[i] = new Thread(ShowThreadInfo);
                thread[i].Name = $"Thread {i}";
                thread[i].Start();

            }
        }


        static void ShowThreadInfo()
        {
            Console.WriteLine(Thread.CurrentThread.Name + " waiting");
            semaphore.WaitOne();
            Console.WriteLine(Thread.CurrentThread.Name + " begins!");
            Thread.Sleep(50);
            Console.WriteLine(Thread.CurrentThread.Name + " releasing...");
            semaphore.Release();
        }
    }
}
