using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_TheManAndHisMoney
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Person gosho = new Person("Gosho", 14);
            gosho.Accounts.Add(new BankAccount("BFG45645", 45.6));
            gosho.Accounts.Add(new BankAccount("BGH45644", 100));

            Console.WriteLine(gosho.GetBalance()); 
        }
    }
}
