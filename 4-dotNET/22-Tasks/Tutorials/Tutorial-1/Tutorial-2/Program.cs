using System;
using System.Threading.Tasks;
namespace Tutorial02
{
    class Program
    {
        static void Main(string[] args)
        {
            int breakIndex = 3;
            var random = new Random();
            var locker = new object();
            Parallel.For(1, 20, (i, state) =>
            {
                Console.WriteLine("Beggining iteration " + i);
                lock (locker)
                {
                    Task.Delay(random.Next(0, 1000)).GetAwaiter().GetResult();
                }
                if (i == breakIndex)
                {
                    Console.WriteLine("Completed iteration " + i);
                    Console.WriteLine("Break in iteration " + breakIndex);
                    state.Break();
                }
            });
            Console.WriteLine("Lowest Break Iteration: " + breakIndex);
        }
    }
}
