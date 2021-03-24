using System;
using System.Collections.Generic;

namespace Tutorial_1
{



    class Program
    {
        static void Main(string[] args)
        {
            var sergiiBankAccount = new BankAccount();

            sergiiBankAccount.MakeDeposit(500000, "Thank you");
            sergiiBankAccount.MakeDeposit(21738678, "Thank you More");
            sergiiBankAccount.MakeDeposit(1243123, "Thank you third times");
            sergiiBankAccount.MakeDeposit(2, "Thank you one more");


            sergiiBankAccount.Owner = "Me";
            sergiiBankAccount.Number = "42";

            sergiiBankAccount.PrintTransactionHistory();
        }
    }
}