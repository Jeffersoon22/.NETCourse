using System;
using System.Diagnostics;
namespace Tutorial_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var watch = new Stopwatch();
            long totalMemoryBefore = GC.GetTotalMemory(false);
            Console.WriteLine("Total Memory Before: \t{0}", totalMemoryBefore);
            watch.Start();
            var array = new int[10000000];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next();
            }
            watch.Stop();
            Console.WriteLine("Array was created. in {0} ms", watch.ElapsedMilliseconds);
            watch.Reset();
            ShowGarbageCollectionState();
            watch.Start();
            GC.Collect();
            Console.WriteLine("Calling GC...");
            GC.WaitForPendingFinalizers();
            watch.Stop();
            Console.WriteLine("Time of collectiong: {0}", watch.ElapsedMilliseconds);
            long totalMemoryAfter = GC.GetTotalMemory(true);
            Console.WriteLine("Total Memory After: \t{0}", totalMemoryAfter);
        }
        public static void Tutorial1()
        {
            int maxGen = GC.MaxGeneration;
            Console.WriteLine("Max Generation: \t{0}", maxGen);
            long totMemory = GC.GetTotalMemory(false);
            Console.WriteLine("Total Memory Before: \t{0}", totMemory);
            var battery = new Battery("Power-1");
            GC.Collect();
            maxGen = GC.MaxGeneration;
            Console.WriteLine("Max Generation after Battery creation: \t{0}", maxGen);
            Console.WriteLine("Generation of Battery: \t{0}", GC.GetGeneration(battery));
            long totalmemoryAfter = GC.GetTotalMemory(false);
            Console.WriteLine("Total Memory After: \t{0}", totalmemoryAfter);
        }
        public static void ShowGarbageCollectionState()
        {
            Console.WriteLine("Generation 0 was checked {0} times", GC.CollectionCount(0));
            Console.WriteLine("Generation 1 was checked {0} times", GC.CollectionCount(1));
            Console.WriteLine("Generation 2 was checked {0} times", GC.CollectionCount(2));
        }
    }
}
