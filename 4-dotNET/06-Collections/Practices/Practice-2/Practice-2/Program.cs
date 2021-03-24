using System;
using System.Collections.Generic;

namespace Practice_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> array = new List<string>(){ "milk", "cheese", "tea", "apple" };
            string sentence ="" ;
            
            while(sentence != "Want to Exit")
            {
                foreach (string i in array)
                {
                    Console.WriteLine(i);
                }

                Console.WriteLine(" ");


                for (; ; )
                {
                    Console.Write("Input str: ");
                    sentence = Console.ReadLine();

                    if (array.Contains(sentence))
                    {
                        string item = sentence;
                        Console.WriteLine($"{item.ToUpper()} already exists in array");
                        continue;
                    }

                    else
                    {
                        array.Add(sentence);

                    }

                    Console.WriteLine(" ");

                    foreach (string a in array)
                    {
                        Console.WriteLine(a);
                    }

                    if (sentence == "Want to Exit")
                    {
                        Console.WriteLine();
                        Console.WriteLine("Goodbye ");
                        return;
                    }
                }
            }
        }
    }
}
