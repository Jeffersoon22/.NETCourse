using Planner.Models;
using System.Collections.Generic;

namespace Planner.Services
{
    public interface IUserService
    {
        IEnumerable<User> GetAll();
        void Add(User user);
    }
}
