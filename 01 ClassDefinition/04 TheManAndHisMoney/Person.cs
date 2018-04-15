using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_TheManAndHisMoney
{
    class Person
    {
        private string name;
        private int age;
        private List<BankAccount> accounts;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }

        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public List<BankAccount> Accounts
        {
            get { return accounts; }
            set { accounts = value; }
        }

        public double GetBalance()
        {
            return accounts.Select(e => e.Balance).Sum();
        }

            
        
    }
}
