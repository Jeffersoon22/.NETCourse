using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace practice_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = "What&#160;is&#160;your&#160;name&#160;&#38;&#160;adress&#63;";

            Console.WriteLine("Test string: \t" + test);

            test = Regex.Replace(test, "&#160;", " ");
            test = Regex.Replace(test, "&#38;", "&");
            test = Regex.Replace(test, "&#63;", "?");

            Console.WriteLine();
            Console.WriteLine("Result: \t" + test);

            Console.ReadKey();

        }
    }
}

