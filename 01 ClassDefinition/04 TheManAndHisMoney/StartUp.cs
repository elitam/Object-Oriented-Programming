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
            Person firstP = new Person("Gosho", 4444);

            firstP.AddAccount(new BankAccount("BG454345", 50));
            firstP.AddAccount(new BankAccount("BG456456", 54));

            Console.WriteLine($"{firstP.Name}'s balance is: {firstP.GetBalance():f2} euro!"); 
        }
    }
}
