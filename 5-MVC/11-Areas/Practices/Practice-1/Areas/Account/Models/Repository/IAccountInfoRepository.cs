using Practice_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice_1.Areas.Account.Models.Repository
{
    public interface IAccountInfoRepository
    {
        IEnumerable<AccountInfo> GetAllCars();
        void AddCar(AccountInfo car);
    }
}
