﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_BankAccount
{
    class BankAccount
    {
        private string id;
        private double balance;

        public BankAccount (string id, double balance)
        {
            this.id = id;
            this.balance = balance;
        }

        public string ID
        {
            get { return id; }
            set { id = value; }
        }
        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        public void Deposit (double amount)
        {
            balance += amount;
        }
        public void Withdraw (double amount)
        {
            balance -= amount;
        }
        public override string ToString()
        {
            return $"Account: {id} | balance: {balance}" ;
        }
    }
}
