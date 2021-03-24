using System;
using System.Collections.Generic;
using System.Text;

namespace Tutorial_1
{
    class BankAccount
    {
        public string Number { get; set; }
        public string Owner { get; set; }
        public decimal Balance { get; set; }

        public List<Transaction> Transactions { get; set; } = new List<Transaction>();

        public void MakeDeposit(decimal amount, string notes = null)
        {
            var newTransaction = new Transaction(amount, notes);
            Transactions.Add(newTransaction);
        }

        public void PrintTransactionHistory()
        {
            Transactions.ForEach(transaction => Console.WriteLine($"Amount: {transaction.Amount} \t " +
                                            $"Date: {transaction.Date} \t Notes: {transaction.Notes}"));

        }
    }
}