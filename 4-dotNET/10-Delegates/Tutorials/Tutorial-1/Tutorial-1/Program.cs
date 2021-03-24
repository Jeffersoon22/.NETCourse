using System;
using System.Collections.Generic;
using System.Linq;
namespace Titorial_1
{
    public delegate void Sort<T>(List<T> list);
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source array:");
            string numbersString = Console.ReadLine();
            var listOfStrings = numbersString.Split(" ").ToList();
            var listOfNumber = listOfStrings.Select(x => ConvertToInt(x)).ToList();
            Sort<int> sort = SortList;
            sort += SortListDesc;
            sort(listOfNumber);
        }
        private static int ConvertToInt(string s)
        {
            return int.Parse(s);
        }
        public static void SortList<T>(List<T> list)
        {
            var result = list.OrderBy(x => x).ToList();
            result.ForEach(x => PrintNumber(x));
            Console.WriteLine();
        }
        public static void SortListDesc<T>(List<T> list)
        {
            var result = list.OrderByDescending(x => x).ToList();
            result.ForEach(x => PrintNumber(x));
            Console.WriteLine();
        }
        public static void PrintNumber<T>(T number)
        {
            Console.Write(number + " ");
        }
    }
}