using Practice_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice_1.Services
{
    public interface IAccount
    {

        IEnumerable<AccountInfo> GetAllAccounts();
        void AddAccount(AccountInfo account);
    }
}
