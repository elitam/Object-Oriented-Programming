using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_TestClient
{
    class StartUp
    {
        static void Main(string[] args)
        {

            var accounts = new Dictionary<string, BankAccount>();

            while (true)
            {
                var commandArgs = Console.ReadLine().Split().ToList();
                var commandType = commandArgs[0];
                if (commandType == "End")
                {
                    return;
                }

                string thisId = commandArgs[1];

                switch (commandType)
                {

                    case "Create":
                        Create(accounts, thisId);
                        break;
                    case "Deposit":
                        double depositAmount = double.Parse(commandArgs[2]);
                        Deposit(accounts, depositAmount, thisId);
                        break;
                    case "Withdraw":
                        double withdrawAmount = double.Parse(commandArgs[2]);
                        Withdraw(accounts, withdrawAmount, thisId);
                        break;
                    case "Print":
                        Print(accounts, thisId);
                        break;
                    default:
                        break;
                }
            }
        }
        private static void Create(Dictionary<string, BankAccount> accounts, string thisId)
        {
            if (accounts.ContainsKey(thisId))
            {
                Console.WriteLine("Account already exist");
            }
            else
            {
                accounts.Add(thisId, new BankAccount(thisId));
            }
        }

        private static void Deposit(Dictionary<string, BankAccount> accounts, double amount, string thisId)
        {

            if (accounts.ContainsKey(thisId))
            {
                accounts[thisId].Balance += amount;
            }
            else
            {
                Console.WriteLine("Account does not exist");

            }
        }

        private static void Withdraw(Dictionary<string, BankAccount> accounts, double amount, string thisId)
        {
            if (accounts.ContainsKey(thisId))
            {
                if (accounts[thisId].Balance >= amount)
                {
                    accounts[thisId].Balance -= amount;
                }
                else
                {
                    Console.WriteLine("Insufficient balance");
                }
            }
            else
            {
                Console.WriteLine("Account does not exist");
            }
        }

        private static void Print(Dictionary<string, BankAccount> accounts, string thisId)
        {
            if (accounts.ContainsKey(thisId))
            {
                Console.WriteLine($"Account ID{thisId}, balance {accounts[thisId].Balance:f2}");
            }
            else
            {
                Console.WriteLine("Account does not exist");
            }
        }



    }
}
