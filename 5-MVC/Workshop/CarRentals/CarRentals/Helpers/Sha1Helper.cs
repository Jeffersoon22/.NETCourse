using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CarRentals.Helpers
{
    public class Sha1Helper
    {
        public static string HashPassword(string source)
        {
            var passwordBuilder = new StringBuilder();

            using var sha1 = new SHA1Managed();
            var hashedBytes = sha1.ComputeHash(Encoding.UTF8.GetBytes(source));
            foreach (var hashedByte in hashedBytes)
            {
                passwordBuilder.Append(hashedByte.ToString("x2"));
            }

            return passwordBuilder.ToString();
        }
    }
}
