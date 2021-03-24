using Millionare.Helpers;
using Millionare.Models;
using Millionare.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Millionare.Services.Implementations
{
    public class UserService : IUserService
    {
        private readonly IRepository<User> _repository;
        public UserService(IRepository<User> repository)
        {
            _repository = repository;
        }
        public void Add(User user)
        {
            user.Password = Sha1Helper.HashPassword(user.Password + Constants.Salt);
            _repository.Add(user);
        }

        public IEnumerable<User> GetAll()
        {
            return _repository.GetAll();
        }

    }
}
