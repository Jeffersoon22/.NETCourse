using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Constants
{
    public class AuthOptions
    {
        public static string Issuer = "JwtTutorialServer";
        public static string audience = "JwtTutorialClient";
        static string Key = "VerySecretString";
        public const double TokenLifetime = 5;
   
        public static SymmetricSecurityKey GatKey=>
            new SymmetricSecurityKey(Encoding.ASCII.GetBytes(Key));


    }
}
