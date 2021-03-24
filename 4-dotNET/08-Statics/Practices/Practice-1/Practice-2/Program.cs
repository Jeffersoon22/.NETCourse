using System;

namespace Practice_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Stundent s1 = new Stundent("Jogn Doe", 19);
            Stundent s2 = new Stundent("Oliver Smith", 20);
            Console.WriteLine("Count of instances: " + Stundent.counter);
            Console.ReadKey();
        }
    }
}
