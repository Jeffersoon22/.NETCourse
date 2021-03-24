using System;
using System.Collections.Generic;
using System.Text;

namespace Tutorial_1
{
    class Transaction
    {
        public decimal Amount { get; set; }
        public DateTime Date => DateTime.Now;
        public string Notes { get; set; }


        public Transaction(decimal amount)
        {
            Amount = amount;
        }
        public Transaction(decimal amount, string notes = null)
        {
            Amount = amount;
            Notes = notes;
        }

    }
}