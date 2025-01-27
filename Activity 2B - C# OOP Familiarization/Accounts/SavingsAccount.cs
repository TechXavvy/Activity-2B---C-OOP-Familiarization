using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_2B___C__OOP_Familiarization.Accounts
{
    public class SavingsAccount : Account
    {
        private DateTime? PrevWithdrawal;

        public SavingsAccount(string ahn, decimal ibal) : base(ahn, ibal)
        {
        }

        public override void Withdraw(decimal amount)
        {
            if (PrevWithdrawal.HasValue && PrevWithdrawal.Value.Date == DateTime.Today)
            {
                Console.WriteLine(">>> Ooops, you can only withdraw once per day. Come back tomorrow! <<<");
                return;
            }

            if (amount > Balance)
            {
                Console.WriteLine(">>> It seems the amount you are trying to withdraw exceeds your current balance! <<<");
                return;
            }

            if (amount <= 0)
            {
                Console.WriteLine(">>> Error! This amount cannot be withdrew. <<<");
                return;
            }

            Balance -= amount;
            PrevWithdrawal = DateTime.Now;
            AddTransaction("Withdrew", amount);
            Console.WriteLine($">>> Successfully withdrew P{amount} from {AccountHolderName}'s savings account. Thank you for using our service! <<<");
        }
    }
}
