using System;

namespace Tutorial_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxGen = GC.MaxGeneration;
            Console.WriteLine("Max Generation: {0}", maxGen);

            long totalMemoryBefore = GC.GetTotalMemory(false);
            Console.WriteLine("Total memory before:\t {0}", totalMemoryBefore);

            maxGen = GC.MaxGeneration;
            var battery = new Battery("Power 1");

            GC.Collect();

            Console.WriteLine("Max Generation after Battery creation: {0}", maxGen);

            Console.WriteLine("Generation of battery: {0}",GC.GetGeneration(battery));
            
            long totalMemoryAfter = GC.GetTotalMemory(false);
            Console.WriteLine("Total memory after: {0}", totalMemoryAfter);

            ShowGarbageCollectionState();

        }

        public static void ShowGarbageCollectionState()
        {

            Console.WriteLine("Generation 0 was checked {0} times", GC.CollectionCount(0));
            Console.WriteLine("Generation 1 was checked {0} times", GC.CollectionCount(1));
            Console.WriteLine("Generation 2 was checked {0} times", GC.CollectionCount(2));
        }
    }
}
