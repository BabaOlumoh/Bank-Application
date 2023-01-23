using System;
using System.Net;
using System.Xml.Linq;

namespace Bank_Application
{
	public class Account : Person
	{
		private string number;
        private double balance;

        public Account(string name, string surname, int yearOfBirth, string address, string number, double balance) : base(name, surname,  yearOfBirth,  address)
        {
            this.number = number;
            this.balance = balance;
        }

        public void Deposit(double amount)
        {
           balance += amount ;
        }

        public bool Withdraw(double amount)
        {
            if (amount <= balance)
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

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Account number: {number}");
            Console.WriteLine();
            Console.WriteLine($"Your current balance is {balance}");
        }
        public void Close()
        {
            Console.WriteLine();
        }
    }
}

