using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_2B___C__OOP_Familiarization.Accounts
{
    public interface IAccount
    {
        void Deposit(decimal amount);
        void Withdraw(decimal amount);
        decimal GetBalance();
    }
}
