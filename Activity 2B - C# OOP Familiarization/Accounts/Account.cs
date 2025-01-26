using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_2B___C__OOP_Familiarization.Accounts
{
    public abstract class Account : IAccount
    {
        public string AccountHolderName { get; set; }
        protected decimal Balance { get; set; }
        public List<string> Transactions { get; } = new List<string>();

        public Account(string ahn, decimal ibal)
        {
            AccountHolderName = ahn;
            Balance = ibal;
            AddTransaction("Account Created", ibal);
        }
        public virtual void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine(">>> Error! This amount cannot be deposited. <<<");
                return;
            }

            Balance += amount;
            AddTransaction("Deposited", amount);
            Console.WriteLine($">>> Succesfully deposited P{amount} to {AccountHolderName}'s account. Thank you for using our service! <<<");
        }

        public decimal GetBalance()
        {
            return Balance;
        }
        public abstract void Withdraw(decimal amount);

        protected void AddTransaction(string type, decimal amount)
        {
            Transactions.Add($"{DateTime.Now}: {type} P{amount} || Total Balance: P{Balance}");
        }
    }
}
