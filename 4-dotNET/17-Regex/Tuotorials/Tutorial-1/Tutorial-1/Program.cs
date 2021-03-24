using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Tutorial_1
{
    class Program
    {
        private const string Success = "Word validated";
        private const string Fail = "Word failed validation";


        static void Main(string[] args)
        {
            Console.WriteLine("Input text: ");

            string text = "Amzng";

            var regex = new Regex("[Aa][a-z]{3}g");

            string result = regex.IsMatch(text) ? Success : Fail;

            Console.WriteLine(result);
        }
    }
}
