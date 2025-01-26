using Activity_2B___C__OOP_Familiarization.Accounts;

namespace Activity_2B___C__OOP_Familiarization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SavingsAccount savAcc = new SavingsAccount("Sara Dueleven", 125000);
            CheckingAccount chkAcc = new CheckingAccount("Phil Helton", 271000, 100000);

            Console.WriteLine("Welcome to Alabank The Big Bank!\n");

            Console.WriteLine($"Sara Dueleven's Savings Account Balance: P{savAcc.GetBalance()}");
            savAcc.Deposit(175000);
            savAcc.Withdraw(200000);
            savAcc.Withdraw(50000);

            Console.WriteLine($"\nPhil Helton's Checking Account Balance: P{chkAcc.GetBalance()}");
            chkAcc.Deposit(500000);
            chkAcc.Withdraw(200000);
            chkAcc.Withdraw(700000);

            Console.WriteLine("\n=============================================================================\nSavings Account Transaction History:");
            foreach (var transaction in savAcc.Transactions)
            {
                Console.WriteLine(transaction);
            }
            Console.WriteLine("=============================================================================");

            Console.WriteLine("\n=============================================================================\nChecking Account Transaction History:");
            foreach (var transaction in chkAcc.Transactions)
            {
                Console.WriteLine(transaction);
            }
            Console.WriteLine("=============================================================================");
        }
    }
}
