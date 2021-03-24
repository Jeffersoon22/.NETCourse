using System;

namespace tutorial_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your name: ");
	    string myAwesomeName = Console.ReadLine();
	    Console.WriteLine($"Hello, {myAwesomeName}");
        }
    }
}
