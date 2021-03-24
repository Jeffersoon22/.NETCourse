using System;
using System.Text.RegularExpressions;

namespace Practice_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input email: ");
            string inputedmail = Console.ReadLine();
            Console.WriteLine();
            new EmailValidator(inputedmail);
            Console.ReadKey();
        }

        class EmailValidator
        {
            private const string pattern = @"^([0-9a-zA-Z]" + @"([\+\-_\.][0-9a-zA-Z]+)*" + @")+" + @"@(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]*\.)+[a-zA-Z0-9]{2,17})$";
            public string Email;

            public EmailValidator(string email)
            {
                Email = email;
                IsValid(Email);
            }
            public static void IsValid(string email)
            {

                bool isvalid = Regex.IsMatch(email, pattern);
                if (isvalid)
                {
                    Console.WriteLine("Email is valid ");
                }
                else
                {
                    Console.WriteLine("Email is invalid ");
                }
            }
        }
    }
}
