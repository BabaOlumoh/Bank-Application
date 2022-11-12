using System.Xml.Serialization;

namespace BankAccount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var accountNum1 = new BankAccount("1234567890O", 2000);
            var accountNum2 = new BankAccount("1234567890T");

            Console.WriteLine("Welcome to 419 mobile money, what would you like to do today?");
            Console.WriteLine("insert w for withdrawal, d for deposit");
            string choice = Console.ReadLine();
            if (choice == "d")
            {
                Console.WriteLine("How much would you like to deposit please?");
                double deposit = Convert.ToDouble(Console.ReadLine());
                accountNum1.Deposit(deposit);
                Console.WriteLine($"Transaction successful! your new balance {accountNum1.GetBalance()}");
            }
            else if (choice == "w")
            {
                Console.WriteLine("Kindly insert withdrawal amount");
                double withdraw = Convert.ToInt32(Console.ReadLine());
                bool isSuccessful = accountNum1.Withdraw(withdraw);

                if (isSuccessful)
                {
                    Console.WriteLine($"Transaction Successful, your new balance is {accountNum1.GetBalance()}");
                }
                else
                {
                    Console.WriteLine($"Transaction Failed! your account balance is {accountNum1.GetBalance()}");
                }
            }
            else
            {
                Console.WriteLine("Invalid selection please try again");
            }
        }// main method
    }// program class
}//namescape class