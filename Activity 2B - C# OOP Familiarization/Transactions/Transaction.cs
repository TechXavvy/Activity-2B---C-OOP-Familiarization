using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_2B___C__OOP_Familiarization.Transactions
{
    public class Transaction
    {
        public DateTime Timestamp { get; }
        public string Type { get; }
        public decimal Amount { get; }
        public decimal NewBalance { get; }

        public Transaction(string type, decimal amount, decimal newbal)
        {
            Timestamp = DateTime.Now;
            Type = type;
            Amount = amount;
            NewBalance = newbal;
        }

        public override string ToString()
        {
            return $"{Timestamp}: {Type} P{Amount} || Total Balance: P{NewBalance}";
        }
    }
}
