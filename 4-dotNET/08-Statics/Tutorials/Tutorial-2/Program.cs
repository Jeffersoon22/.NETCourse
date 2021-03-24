using System;

namespace Tutorial_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Animals.NumberOfLegs = 8;

            var cat = new Animals("cat");
            Console.WriteLine();

            var dog = new Animals("dog");
            Console.WriteLine();

            var unknown = new Animals();
        }
    }
}
