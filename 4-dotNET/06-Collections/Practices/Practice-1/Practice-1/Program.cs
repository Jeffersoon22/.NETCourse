using System;
using System.Collections.Generic;

namespace Practice_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SIGN IN");
            Console.Write("USERNAME: ");
            string username = Console.ReadLine();
            

            Dictionary<string, string> userData = new Dictionary<string, string>()
            {
                {"giorgi","grg123"} ,
                {"davit","qwe890"},
                {"davit0","zxc000" },
                {"malvina","paskey1"}};

            bool containsKey = userData.ContainsKey(username);
            if (containsKey) 
            {
                Console.Write("PASSWORD: ");
                string password = Console.ReadLine();
                if (userData[username] == password)
                {
                    Console.WriteLine($"Hello, {username}");
                    Console.ReadKey();
                }
                else if (userData[username] != password)
                {
                    Console.WriteLine("Incorrect password");
                }
            }
            else if (!containsKey)
            {
                Console.WriteLine("A user with this name could not be found.");
            }
            Console.ReadKey();
        }
    }
}
 