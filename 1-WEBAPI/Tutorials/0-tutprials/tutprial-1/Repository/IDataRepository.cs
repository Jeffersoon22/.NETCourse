using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tutprial_1.Models;

namespace tutprial_1.Repository
{
    public interface IDataRepository
    {
        IEnumerable<User> GetUsers();
        User GetUser(int id);

        User Add(User user);
        bool Delete(int id);
    }
}
