using System;
using System.Text;
using System.Security.Cryptography;
using System.Linq;


namespace Practice_1
{
    class Program
    {
        static void Main(string[] args)
        {
            const string value= "74871a3f25c8d84ec72ced05cd62ff4d8306b9ca";

            Console.Write("Input password: ");
            string password = "";
            ConsoleKeyInfo key;


            do
            {
                key = Console.ReadKey(true);

                if (key.Key != ConsoleKey.Backspace)
                {
                    password += key.KeyChar;
                    Console.Write("*");
                }
                else
                {
                    Console.Write("\b");
                }

                
                if (key.Key == ConsoleKey.Enter)
                {
                    break;
                } 
            } while (key.Key != ConsoleKey.Enter);



            Console.WriteLine();
            Console.WriteLine();

            string sbuilder = "";

            using var sha1 = new SHA1Managed();
            var hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(password)).ToList();

            hash.ForEach(x => sbuilder += x.ToString("x2"));
            

            if (sbuilder == value)
            {
                Console.WriteLine("Password is correct");
            }
            else
            {
                Console.WriteLine("Password is not correct");
            }
            Console.ReadKey();

        }
    }
}
 