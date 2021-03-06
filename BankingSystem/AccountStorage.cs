using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    public class AccountStorage
    {
        static List<AccountOpening> allAccounts = new List<AccountOpening>(); 

        public void StoreAccountInfo(AccountOpening info)
        {
            Console.Clear();
            allAccounts.Add(info);

            Console.WriteLine("\nAccount has been successfully created.");
            Console.WriteLine("Account number is " + info.accountNumber);
        }

        public void ShowAccountDetails(int accNumb)
        {
            Console.Clear();
            int i, flag = 0;
            for (i = 0; i < allAccounts.Count; i++)
            {
                if (allAccounts[i].accountNumber == accNumb)
                {
                    flag = 1;
                    break;
                }
            }

            if (flag == 1)
            {
                Console.WriteLine("\nName: " + allAccounts[i].Name);
                Console.WriteLine("Current Balance: " + allAccounts[i].Balance);
                Console.WriteLine("Total Transections: " + allAccounts[i].Transactions);
            }
            else
                Console.WriteLine("Account Not Found!");   
        }

        public void DepositMoney(int accNumb, float amount)
        {
            Console.Clear();
            int i, flag = 0;
            for (i = 0; i < allAccounts.Count; i++)
            {
                if (allAccounts[i].accountNumber == accNumb)
                {
                    flag = 1;
                    break;
                }
            }

            if (flag == 1)
            {
                allAccounts[i].Balance += amount;
                allAccounts[i].Transactions += 1;

                Console.WriteLine("Deposit operation is successfully done!");
                Console.WriteLine("Current Balance: " + allAccounts[i].Balance);
            }
            else
                Console.WriteLine("Account Not Found!");  
        }

        public void WithdrawMoney(int accNumb, float amount)
        {
            Console.Clear();
            int i, flag = 0;
            for (i = 0; i < allAccounts.Count; i++)
            {
                if (allAccounts[i].accountNumber == accNumb)
                {
                    flag = 1;
                    break;
                }
            }

            if (flag == 1)
            {
                if (allAccounts[i].accountType == 1)
                {
                    if (amount >= allAccounts[i].Balance)
                        Console.WriteLine("You don't have enough balance.");
                    else if (amount < allAccounts[i].Balance)
                    {
                        allAccounts[i].Balance -= amount;
                        allAccounts[i].Transactions += 1;

                        Console.WriteLine("Withdraw operation is successfully done!");
                        Console.WriteLine("Current Balance: " + allAccounts[i].Balance);
                    }
                }
                else
                {
                    if (amount > allAccounts[i].Balance)
                        Console.WriteLine("You don't have enough balance.");
                    else
                    {
                        allAccounts[i].Balance -= amount;
                        allAccounts[i].Transactions += 1;

                        Console.WriteLine("Withdraw operation is successfully done!");
                        Console.WriteLine("Current Balance: " + allAccounts[i].Balance);
                    }
                }
            }
            else
                Console.WriteLine("Account Not Found!");
        }

        public void TransferMoney(int sender, int receiver, float amount)
        {
            Console.Clear();
            int i, j, flag1 = 0, flag2 = 0;
            for (i = 0; i < allAccounts.Count; i++)
            {
                if (allAccounts[i].accountNumber == sender)
                {
                    flag1 = 1;
                    break;
                }
            }
            for (j = 0; j < allAccounts.Count; j++)
            {
                if (allAccounts[j].accountNumber == receiver)
                {
                    flag2 = 1;
                    break;
                }
            }

            if (flag1 == 1 && flag2 == 1)
            {
                if (amount < allAccounts[i].Balance)
                {
                    allAccounts[i].Balance -= amount;
                    allAccounts[j].Balance += amount;
                    allAccounts[i].Transactions++;
                    allAccounts[j].Transactions++;
                }
                else
                    Console.WriteLine("Sender doesn't have enough balance!");
            }
            else
                Console.WriteLine("Any of the account number is wrong!");

            Console.WriteLine("Transfer operation is successfully done!");
        }
    }
}
