using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Practices.models;

namespace Practices.Services.Interfaces
{
    public interface IUserService
    {
       User GetUserByName(string Name);
    }
}
