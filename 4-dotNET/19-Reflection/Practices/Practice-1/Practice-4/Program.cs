using NumberHelper;
using System;
using System.Reflection;

namespace Practice_4
{
    public class Program
    {
        static void Main(string[] args)
        {
            Type type = typeof(NumberHelper.Numberhelper);
            var obj = Activator.CreateInstance(type) as NumberHelper.Numberhelper;

            Console.Write("Input value: ");
            string strvalue = Console.ReadLine();
            int value;
            value = int.Parse(strvalue);

            Console.WriteLine("IncreaseCounter: " + obj.IncreaseCoutner(value));
            Console.WriteLine("RootOfNumber: " + obj.RootOfNumver(value));
            Console.WriteLine("SquareNumber: " + obj.SquareNumber(value));

            Console.Read();
        }
    }
}