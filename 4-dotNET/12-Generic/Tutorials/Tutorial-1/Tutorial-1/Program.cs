using System;

namespace Tutorial_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var point = new Point<int>(30,30);
            var point2 = new Point<double>(15.321, 15.757);
            var point3 = new Point<string>("hello","world");

            Console.WriteLine("Point: " + point);
            Console.WriteLine("Point: " + point2);
            Console.WriteLine("Point: " + point3);

            point = point.ResetPoint();
            point3 = point3.ResetPoint();

            Console.WriteLine("Point after reset: " + point);
            Console.WriteLine("Point after reset: " + point3);

        }

    }
}
