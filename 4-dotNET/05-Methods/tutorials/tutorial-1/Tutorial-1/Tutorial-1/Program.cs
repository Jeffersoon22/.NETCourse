using System;

namespace Tutorial_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var userInput = GetUserInput();
            WordCount(userInput);

        }

        public static string  GetUserInput()
        {
            Console.Write("Input string: ");
            string input = Console.ReadLine();
            return input;        
        }

        public static void WordCount(string userInput)
        {
            string[] stringArray = userInput.Split(" ");
            Console.WriteLine("Number of words in the string: " + stringArray.Length);
        }
    }
}
