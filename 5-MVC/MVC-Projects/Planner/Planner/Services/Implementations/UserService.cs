using Planner.Helpers;
using Planner.Models;
using System.Collections.Generic;

namespace Planner.Services
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
