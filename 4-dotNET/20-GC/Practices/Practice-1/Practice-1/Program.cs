using System;

namespace Practice_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BASIC INFORMATION ABOUT THE SYSTEM:");
            Console.WriteLine();
            Console.WriteLine();
            
            Console.WriteLine($"OS: {Environment.OSVersion} .NET Framework: {Environment.Version}");

            Console.WriteLine();
            Console.WriteLine("GC INFORMATION: ");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"Count of bytes in heap: {GC.GetTotalMemory(false)} Max Generation: {GC.MaxGeneration}");

            Bike yamaha = new Bike("Yamaha", 135);
            Console.WriteLine($"{yamaha.Name} is going {yamaha.CurrentSpeed}");
            Console.WriteLine($"Generation of {yamaha.Name} : {GC.GetGeneration(yamaha)}");
            Console.WriteLine();
            Console.WriteLine("Garbage collection ...");
            GC.Collect();
            Console.WriteLine($"Generation of object : {GC.GetGeneration(yamaha)}");
            Console.ReadKey();
        }
    }
}
