using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Helper
{
    public static class HashHelper
    {
        public static string HashHash(this string source)
        {
            try
            {
                var result = new StringBuilder(32);
                using (SHA1 sha1 = new SHA1Managed())
                {
                    var hashEdBytes = sha1.ComputeHash(Encoding.UTF8.GetBytes(source));
                    foreach (var b in hashEdBytes)
                    {
                        result.Append(b.ToString("X2"));
                    }
                }
                return result.ToString();
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
