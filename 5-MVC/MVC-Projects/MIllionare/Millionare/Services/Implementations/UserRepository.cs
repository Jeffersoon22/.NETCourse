using Millionare.Helpers;
using Millionare.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Millionare.Services.Implementations
{
    public class UserRepository : IRepository<User>
    {
        private List<User> _user = new List<User>
        {
            new User {UserName="admin",Password=Sha1Helper.HashPassword("admin"+Constants.Salt)},
        };
        public void Add(User item)
        {
            _user.Add(item);
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetAll()
        {
            return _user;
        }

        public void Update(User item)
        {
            throw new NotImplementedException();
        }
    }
}
