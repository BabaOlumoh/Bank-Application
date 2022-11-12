using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class BankAccount //Attributes/Data
    {
        private string number;
        private double balance;

        public BankAccount(string num, double bal) //Constructor 1
        {
            this.number = num;
            this.balance = bal;
        }
        public BankAccount(string num) //overloading constructor
        {
            this.number = num;
            balance = 0;
        }

        //Methods
        public void Deposit(double amount)
        {
            balance += amount;
        }

        public bool Withdraw(double amount)
        {
            if (balance > amount)
            {
                balance -= amount;
                return true;
            }
            return false;
        }
        public double GetBalance()
        {
            return balance;
        }
        public string GetNumber()
        {
            return number;
        }
        public void Close()
        {
            balance = 0;
        }
    }
}
