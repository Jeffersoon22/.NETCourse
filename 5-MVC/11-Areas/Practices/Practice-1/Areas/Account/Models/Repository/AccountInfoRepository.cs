using Practice_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice_1.Areas.Account.Models.Repository
{
    public class AccountInfoRepository : IAccountInfoRepository
    {
        private List<AccountInfo> _accounts = new List<AccountInfo>
        {
            new AccountInfo {UserName="Tatali22",Password="Tatali11",ClientId=1,CodeQuestion="What is your favorite color?",CodeAnswear="Purple"},
        };
        public void AddCar(AccountInfo account)
        {
            _accounts.Add(account);
        }

        public IEnumerable<AccountInfo> GetAllCars()
        {
            return _accounts;
        }
    }
}
