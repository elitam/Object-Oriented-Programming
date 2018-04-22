using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_BankAccount
{
    class StartUp
    {
        static void Main(string[] args)
        {
            BankAccount acc = new BankAccount("BG48645156", 545.4);
            acc.Withdraw(15);
            acc.Deposit(2);
            Console.WriteLine(acc.ToString());

        }
    }
}
