using Millionare.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Millionare.Services.Interfaces
{
    public interface IUserService
    {
        IEnumerable<User> GetAll();
        void Add(User user);
    }
}
