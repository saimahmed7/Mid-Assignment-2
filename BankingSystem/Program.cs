using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    class Program
    {
        public static int randomAccountNumber = 1000;
        public static string mainMenuCommand = string.Empty;
        public static string openMenuCommand = string.Empty;
        public static string accountMenuCommand = string.Empty;
        public static int accountType;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Developers Bank.");
            Console.WriteLine("\n\n# Type the following commands to select any options.....\n");
            Console.WriteLine("1. Account Opening (command - open)");
            Console.WriteLine("2. Money Transaction (command - account)");
            Console.WriteLine("3. Exit Application (command - quit)");
            

            while (mainMenuCommand.ToLower() != "quit")
            {
                Console.Clear();
                Console.WriteLine("Welcome to Developers Bank.");
                Console.WriteLine("\n\n# Type the following commands to select any options.....\n");
                Console.WriteLine("1. Account Opening (command - open)");
                Console.WriteLine("2. Money Transaction (command - account)");
                Console.WriteLine("3. Exit Application (command - quit)");
                Console.Write("\nYour Command: ");
                mainMenuCommand = Console.ReadLine();
                mainMenuCommand = mainMenuCommand.ToLower();

                switch (mainMenuCommand)
                {
                    case "open":
                        openMenuCommand = string.Empty;
                        var opening = new AccountOpening();
                        opening.WelcomeMessage();

                        while (openMenuCommand.ToLower() != "quit")
                        {
                            opening.MenuOptions();
                            Console.Write("\nYour Command: ");
                            openMenuCommand = Console.ReadLine();

                            if (openMenuCommand.ToLower() != "quit")
                            {
                                if (openMenuCommand.ToLower() == "savings")
                                    accountType = 1;
                                else if (openMenuCommand.ToLower() == "checking")
                                    accountType = 2;

                                var newAccount = new AccountOpening();
                                var storeAccount = new AccountStorage();
                                newAccount.TakeInfo(accountType, ++randomAccountNumber);
                                storeAccount.StoreAccountInfo(newAccount);
                            }
                        }
                        break;

                    case "account":
                        accountMenuCommand = string.Empty;
                        var account = new Transactions();
                        account.WelcomeMessage();

                        while (accountMenuCommand.ToLower() != "quit")
                        {
                            account.MenuOptions();
                            Console.Write("\nYour Command: ");
                            accountMenuCommand = Console.ReadLine();
                            Transactions transaction = new Transactions();

                            switch (accountMenuCommand)
                            {
                                case "show":
                                    transaction.ShowDetails();
                                    break;
                                case "deposit":
                                    transaction.MakeDeposit();
                                    break;
                                case "withdraw":
                                    transaction.MakeWithdraw();
                                    break;
                                case "transfer":
                                    transaction.MoneyTransfer();
                                    break;
                            }
                        }
                        break;
                }
            }
        }
    }
}
