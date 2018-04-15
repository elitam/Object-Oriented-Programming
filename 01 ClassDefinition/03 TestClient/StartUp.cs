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
           
            
            var acc = new Dictionary<string, BankAccount>();

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
                        Create(acc, thisId);
                        break;
                    case "Deposit":
                        Deposit(acc, commandArgs, thisId);
                        break;
                    case "Withdraw":
                        Withdraw(acc, commandArgs, thisId);
                        break;
                    case "Print":
                        Print(acc, thisId);
                        break;
                    default:
                        break;
                }
            }
        }

        private static void Print(Dictionary<string, BankAccount> acc, string thisId)
        {
            if (acc.ContainsKey(thisId))
            {
                Console.WriteLine($"Account ID{thisId}, balance {acc[thisId].Balance:f2}");
            }
            else
            {
                Console.WriteLine("Account does not exist");
            }
        }

        private static void Withdraw(Dictionary<string, BankAccount> acc, List<string> commandArgs, string thisId)
        {
            double amoun2t = double.Parse(commandArgs[2]);

            if (acc.ContainsKey(thisId) && acc[thisId].Balance >= amoun2t)
            {
                acc[thisId].Balance -= amoun2t;
            }
            else
            {
                if (acc.ContainsKey(thisId))
                {
                    Console.WriteLine("Insufficient balance");
                }
                else
                {
                    Console.WriteLine("Account does not exist");
                }
            }
        }

        private static void Deposit(Dictionary<string, BankAccount> acc, List<string> commandArgs, string thisId)
        {
            double amount = double.Parse(commandArgs[2]);

            if (acc.ContainsKey(thisId))
            {
                acc[thisId].Balance += amount;
            }
            else
            {
                Console.WriteLine("Account does not exist");

            }
        }

        private static void Create(Dictionary<string, BankAccount> acc, string thisId)
        {
            if (acc.ContainsKey(thisId))
            {
                Console.WriteLine("Account already exist");
            }
            else
            {
                acc.Add(thisId, new BankAccount(thisId));
            }
        }
    }
}
