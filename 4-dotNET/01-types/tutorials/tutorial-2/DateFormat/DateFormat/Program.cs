using System;

namespace DateFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            var date = DateTime.Now.ToString("dddd, dd MMMM yyyy");
            Console.WriteLine(date);

            Console.WriteLine();

            var otherDate = DateTime.Now.ToString("dddd, yyyy");
            Console.WriteLine(otherDate);

        }
    }
}
