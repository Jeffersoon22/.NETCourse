using System;

namespace First4charOfGivenString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input string: ");
            string inputString = Console.ReadLine();

            Console.WriteLine();

            string first4char = inputString.Substring(0, 4);
            Console.WriteLine($"New string: {first4char}");
            Console.ReadKey();
        }
    }
}