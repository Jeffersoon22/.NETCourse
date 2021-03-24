using System;

namespace Practice_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input value: ");
            string value = Console.ReadLine();
            double intvalue = double.Parse(value);

            
            Console.WriteLine("Currency format: " + intvalue.ToString("C"));
            Console.WriteLine("Exponential format: " + intvalue.ToString("E"));
            Console.WriteLine("General format: " + intvalue.ToString("G"));
            Console.WriteLine("Percent format: " + intvalue.ToString("P"));
        }
    }
}
