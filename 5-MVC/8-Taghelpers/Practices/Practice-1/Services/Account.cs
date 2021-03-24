using Newtonsoft.Json;
using Practice_1.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Practice_1.Services
{
    public class Account : IAccount
    {
        private string Filename = "Accounts.json";
        List<AccountInfo> createdAccounts = new List<AccountInfo>();
        public void AddAccount(AccountInfo account)
        {
            try
            {
                if (!File.Exists(Filename))
                {
                    File.Create(Filename).Close();
                }
                else
                {
                    var jsnText = File.ReadAllText(Filename);
                    createdAccounts = JsonConvert.DeserializeObject<List<AccountInfo>>(jsnText);
                }
            }
            catch
            {

            }
            createdAccounts.Add(account);
            File.WriteAllText(Filename, JsonConvert.SerializeObject(createdAccounts));
        }

        public IEnumerable<AccountInfo> GetAllAccounts()
        {
            try
            {
                var jsn = File.ReadAllText(Filename);
                createdAccounts = JsonConvert.DeserializeObject<List<AccountInfo>>(jsn);
            }
            catch
            {

            }
                return createdAccounts;
        }
    }
}
