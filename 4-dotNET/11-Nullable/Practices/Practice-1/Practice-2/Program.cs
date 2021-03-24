using System;
using System.Drawing;

namespace Practice_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var a = new Point(20, 20);
            var b = new Point(25, 22);
            bool equals = a == b;
            bool lessThan = a < b;
            bool moreThan = a > b;
            bool equalOrMore = a >= b;
            bool equalOrLess = a <= b;
            Console.WriteLine("First point: " + a);
            Console.WriteLine("Second point: " + b);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(a + "=="+ b);
            Console.WriteLine("Result: " + equals);
            Console.WriteLine();
            Console.WriteLine(a + "<" + b);
            Console.WriteLine("Result: " + lessThan);
            Console.WriteLine();
            Console.WriteLine(a + ">" + b);
            Console.WriteLine("Result: " + moreThan);
            Console.WriteLine();
            Console.WriteLine(a + "<=" + b);
            Console.WriteLine("Result: " + equalOrLess);
            Console.WriteLine();
            Console.WriteLine(a + ">=" + b);
            Console.WriteLine("Result: " + equalOrMore);
            Console.ReadKey();


        }
    }
}
