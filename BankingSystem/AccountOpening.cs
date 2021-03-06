using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    public class AccountOpening
    {
        public string Name, Address, dateOfBirth;
        public int Transactions, accountNumber, accountType;
        public float Balance;

        List<AccountOpening> allAccounts = new List<AccountOpening>(5); 

        Random random = new Random();
       
        public void TakeInfo(int accType, int accNumb)
        {
            Console.WriteLine("Please provide the Following information!");
            
            Console.Write("Full Name: ");
            Name = Console.ReadLine();

            Console.Write("Address: ");
            Address = Console.ReadLine();

            Console.Write("Date of Birth: ");
            dateOfBirth = Console.ReadLine();

            Console.Write("Initial Deposite Amount: ");
            Balance = Convert.ToInt32(Console.ReadLine());

            Transactions = 0;
            accountNumber = accNumb;
            accountType = accType;
        }

        public void WelcomeMessage()
        {
            Console.WriteLine("Welcome to Account Opening Section.");
        }

        public void MenuOptions()
        {
            Console.WriteLine("\n\n# Type the following commands to select any options.....\n");
            Console.WriteLine("1. Open Savings Account (command - savings)");
            Console.WriteLine("2. Open Checking Account (command - checking)");
            Console.WriteLine("3. Return to Mani Menu (command - quit)");
        }
    }
}
