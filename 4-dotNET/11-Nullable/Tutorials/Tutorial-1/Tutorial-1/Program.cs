using System;

namespace Tutorial_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new Point (30 ,30 );
            var b = new Point(20, 20);
            var c = a - b;

            var sum = a + b;
            var subtract = a - b;

            //Console.WriteLine(c);
            Console.WriteLine("Overload operator +: ");
            Console.WriteLine("Result: " +  sum);
            Console.WriteLine();
            Console.WriteLine("Overload operator -: ");
            Console.WriteLine("Result: " + subtract);
            Console.ReadKey();
        }
    }
}
