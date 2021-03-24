using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Tutorial_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var escSymbols = new List<string>()
            {
                Regex.Escape("\n"),
                Regex.Escape("\t"),
            };

            string input = "\tThis\n is\n text";

            Console.WriteLine(input);

            foreach (var symbol in escSymbols)
            {
                input = Regex.Replace(input, symbol, string.Empty);
            }

            Console.WriteLine($"New string {input}");
        }
    }
}
