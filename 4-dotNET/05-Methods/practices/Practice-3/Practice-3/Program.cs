using System;

namespace Practice_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a: ");
            string stringA = Console.ReadLine();
            double aNum = double.Parse(stringA);

            Console.Write("Input c: ");
            string stringC = Console.ReadLine();
            double cNum = double.Parse(stringC);
            if (aNum <= 1 || cNum <= 1)
            {
                Console.WriteLine("a and c must be more than 1!!!");
                Console.ReadKey();
            }

            Console.Write("Input agle°: ");
            string stringAngle = Console.ReadLine();
            double angleNum = double.Parse(stringAngle);

            if ( aNum <=1 || cNum <= 1)
            {
                Console.WriteLine("a and c must be more than 1!!!");
                Console.ReadKey();
            }
            else if(angleNum < 1 || angleNum > 179)
            {
                Console.WriteLine();
                Console.WriteLine("Agle value should be in range 1 ... 179");
                Console.ReadKey();
            }
            else
            {
                var result = CalculateTriangleArea(aNum,cNum,angleNum);
                Console.WriteLine(result);
                Console.ReadKey();
            }
            

        }

        public static double CalculateTriangleArea(double a, double c, double angle)
        {
            
            double b = Math.PI * angle / 180;
            double sinAngle = Math.Sin(b);
            var areaOfTheTriangle = 0.5 * a * c * sinAngle;
            return areaOfTheTriangle;
        }
    }
}
