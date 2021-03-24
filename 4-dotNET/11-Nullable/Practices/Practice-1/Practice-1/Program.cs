using System;

namespace Practice_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new Point(30, 30);
            var b = new Point(20, 20);
            var c = new Point(10, 10);

            Console.WriteLine("Overload operator --: on point " + a);
            var min = --a;
            Console.WriteLine("Result: " + min);
            Console.WriteLine();


            Console.WriteLine("Overload operator ++: on point " + b);
            var plus = b++;
            Console.WriteLine("Result: " + plus);
            Console.WriteLine();


            int value = 3;
            Console.WriteLine("Overload operator *: on point " + c);

            var multiplication = c * value;
            Console.WriteLine("multiply by " + value);
            Console.WriteLine("Result: " + multiplication);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
