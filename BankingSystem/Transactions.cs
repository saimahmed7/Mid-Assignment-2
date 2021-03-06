using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    class Transactions
    {
        public int accNumber, accNumbRec;
        public float amount;

        public void WelcomeMessage()
        {
            Console.WriteLine("Welcome to Transaction Section.");
        }

        public void MenuOptions()
        {
            Console.WriteLine("\n\n# Type the following commands to select any options.....\n");
            Console.WriteLine("1. Deposit Money (command - deposit)");
            Console.WriteLine("2. Withdraw Money (command - withdraw)");
            Console.WriteLine("3. Transfer Money (command - transfer)");
            Console.WriteLine("4. Show Account Details (command - show)");
            Console.WriteLine("5. Return to Mani Menu (command - quit)");
        }

        public void MakeDeposit()
        {
            Console.Clear();
            Console.Write("Enter account number: ");
            accNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Deposit Amount: ");
            amount = Convert.ToInt32(Console.ReadLine());

            AccountStorage acc = new AccountStorage();
            acc.DepositMoney(accNumber, amount);
        }

        public void MakeWithdraw()
        {
            Console.Clear();
            Console.Write("Enter account number: ");
            accNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Withdraw Amount: ");
            amount = Convert.ToInt32(Console.ReadLine());

            AccountStorage acc = new AccountStorage();
            acc.WithdrawMoney(accNumber, amount);
        }

        public void ShowDetails()
        {
            Console.Clear();
            Console.Write("Enter account number: ");
            accNumber = Convert.ToInt32(Console.ReadLine());
            AccountStorage acc = new AccountStorage();
            acc.ShowAccountDetails(accNumber);
        }

        public void MoneyTransfer()
        {
            Console.Clear();
            Console.Write("Sender's account number: ");
            accNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Receiver's account number: ");
            accNumbRec = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Amount: ");
            amount = Convert.ToInt32(Console.ReadLine());

            AccountStorage acc = new AccountStorage();
            acc.TransferMoney(accNumber, accNumbRec, amount);
        }
    }
}
