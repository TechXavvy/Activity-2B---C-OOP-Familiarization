using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_2B___C__OOP_Familiarization.Accounts
{
    public class CheckingAccount : Account
    {
        private readonly decimal MaxOverdraft;

        public CheckingAccount(string ahn, decimal ibal, decimal mod) : base(ahn, ibal)
        {
            MaxOverdraft = mod;
        }

        public override void Withdraw(decimal amount)
        {
            if (amount > Balance + MaxOverdraft)
            {
                Console.WriteLine(">>> Oops, you have already reached the overdraft limit! <<<");
                return;
            }

            if (amount <= 0)
            {
                Console.WriteLine(">>> Error! This amount cannot be withdrew. <<<");
                return;
            }

            Balance -= amount;
            AddTransaction("Withdrew", amount);
            Console.WriteLine($">>> Succesfully withdrew P{amount} from {AccountHolderName}'s checking account. Thank you for using our service! <<<");
        }
    }
}
