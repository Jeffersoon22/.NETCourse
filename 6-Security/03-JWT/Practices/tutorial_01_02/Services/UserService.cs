using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Practices.Data;
using Practices.models;
using Practices.Services.Interfaces;

namespace Practices.Services
{
    public class UserService : IUserService
    {
        private readonly JwtDbContext _context;

        public UserService(JwtDbContext context)
        {
            _context = context;
        }
        public User GetUserByName(string Name)
        {
            return _context.Users.FirstOrDefault(x => x.Username == Name);
        }
    }
}
