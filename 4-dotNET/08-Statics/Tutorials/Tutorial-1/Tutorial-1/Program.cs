using System;

namespace Tutorial_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string helloWorld = "some string";
            Console.WriteLine(helloWorld);
            Console.WriteLine(helloWorld.ToHtmlComment());
            Console.WriteLine(helloWorld.CutByHalf());
        }
    }
}
