using System;
using System.Collections.Generic;

namespace Practice_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            Console.Write("input string: ");
            string input = Console.ReadLine();
            
            for (int i=0; i< input.Length; i++)
            {
                if (IsVowel(input[i]))
                {
                    count++;
                }
            }
            Console.WriteLine($"Num of vowels: {count}");
            Console.ReadKey();
        }

        public static bool IsVowel(char letter)
        {
            if (letter == 'a' || 
                letter == 'e' || 
                letter == 'i' || 
                letter == 'o' || 
                letter == 'u') 
            {
                return true;
            }
            return false;
        }
    }
}
