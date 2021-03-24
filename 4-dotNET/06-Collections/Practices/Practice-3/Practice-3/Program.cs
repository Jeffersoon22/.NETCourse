using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int option = 0;
            while(option !=3)
            {
                Console.WriteLine();
                Console.Write("1. SIGN IN\n" +"2. SIGN UP\n" +"3. EXIT\n"+"Select option: ");
                string optionString = Console.ReadLine();
                option = int.Parse(optionString);


                Dictionary<string, string> user = new Dictionary<string, string>() {
                    { "giorgi", "grg123"},
                    { "davit", "qwe890"},
                    {"davit0", "zxc000" },
                    {"malvina", "paskey1" }};

                if (option == 1)
                {
                    Console.Write("USERNAME: ");
                    string username = Console.ReadLine();
                    Console.WriteLine();
                    Console.Write("PASSWORD: ");
                    string password = Console.ReadLine();

                    if (!user.ContainsKey(username))
                    {
                        Console.WriteLine();
                        Console.WriteLine("A user with this name could not be found.");
                    }
                    else if (user[username] == password)
                    {
                        Console.WriteLine();
                        Console.WriteLine($"Hello, {username} !");
                    }
                    else if (user[username] != password)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Incorrect password");
                    }
                    
                }
                else if(option == 2)
                {
                    string userName;
                    Console.WriteLine();
                    Console.Write("Username: ");
                    userName = Console.ReadLine();
                    Console.WriteLine();
                    string password;
                    Console.Write("Password: ");
                    password = Console.ReadLine();

                    if (!user.ContainsKey(userName) && password.Length >= 6)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Success");

                    }
                    else if (user.ContainsKey(userName))
                    {
                        Console.WriteLine();
                        Console.WriteLine("Username is already taken.");

                    }
                    
                }
                
            }
            Console.WriteLine("Exit..");
            Console.ReadKey();
        }
    }
}
