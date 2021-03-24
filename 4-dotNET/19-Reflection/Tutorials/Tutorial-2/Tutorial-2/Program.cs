using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Tutorial_2
{
    class Program
    {
        private static Dictionary<string, Type> _typeDictionary = new Dictionary<string, Type>()
        {
            {"1" , typeof(StringBuilder) },
            {"2", typeof(Random) },
            {"3",typeof(Regex) },
        };

        static void Main(string[] args)
        {
            Console.WriteLine("What would you like to create?");
            Console.WriteLine("1. StringBuilder ");
            Console.WriteLine("2. Random ");
            Console.WriteLine("3. Regex");
            Console.WriteLine();

            var choice = Console.ReadLine();
            Console.WriteLine();
            int i = (int)Activator.CreateInstance(typeof(int));

            var hasType = _typeDictionary.TryGetValue(choice, out Type type);
            if (!hasType) return;

            var isRegex = type == typeof(Regex);
            var arguments = new object[1];
            if (isRegex)
            {
                arguments[0] = "[a-z]";
            }


            var instance = isRegex ? Activator.CreateInstance(type, arguments) : Activator.CreateInstance(type);
            Console.WriteLine(instance.GetType());
            Console.ReadKey();  
        }
    }
}
