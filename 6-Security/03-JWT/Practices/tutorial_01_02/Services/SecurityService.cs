using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Practices.Constants;
using Practices.Helper;
using Practices.models;
using Practices.Services.Interfaces;

namespace Practices.Services
{
    public class SecurityService : ISecurityService
    {
        public JwtResponse IssueJwtToken(User user)
        {
            var now = DateTime.Now;
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name,user.Username),
                new Claim(ClaimTypes.Role,user.Username.Contains("Nato")
                                                                ? "Teacher" : "Student"),
            };

            var jwt = new JwtSecurityToken(
                issuer: AuthOptions.Issuer,
                audience: AuthOptions.audience,
                claims: claims,
                notBefore: now,
                expires: now.AddMinutes(AuthOptions.TokenLifetime),
                signingCredentials: new SigningCredentials(AuthOptions.GatKey, SecurityAlgorithms.HmacSha256));

            var token = new JwtSecurityTokenHandler().WriteToken(jwt);

            return new JwtResponse
            {
                UserName = user.Username,
                Token = token,
            };
        }

        public bool VerifyUserPassword(User user, string password)
        {
            return user.HashedPassword == password.HashHash();


        }

    }
}
