using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Tutorial_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write string to hash: ");
            string input = Console.ReadLine();
            Console.WriteLine();
            string hash = GetSHa1(input);
            Console.WriteLine();
            Console.WriteLine("Your hash: " + hash);

            string salt = GenerateSalt();
            Console.WriteLine("Generated salt: {0}", salt);
            Console.WriteLine();

            string saltedHash = GetSHa1(hash + salt);
            Console.WriteLine("Salted hash: {0}", saltedHash);

        }

        private static string GenerateSalt()
        {
            string alphabet = "ABCDEFGHIKLMNOPQRSTVXYZ".ToLower();
            var chars = alphabet.ToCharArray();
            var random = new Random();
            var saltBuilder = new StringBuilder();
            chars.ToList().ForEach(c =>
                saltBuilder = random.Next(0, 10) % 2 == 0
                    ? saltBuilder.Append(c)
                    : saltBuilder);
            return saltBuilder.ToString();
        }

        private static string GetSHa1(string input)
        {
            using var sha1 = new SHA1Managed();
            var hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(input)).ToList();


            var sbuilder = new StringBuilder();

            hash.ForEach(x => sbuilder.Append(x.ToString("x2")));

            return sbuilder.ToString();



        }
    }
}
