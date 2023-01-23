namespace Bank_Application;
class Program
{
    static void Main(string[] args)
    {
        try
        {
            //Onboarding
            Console.WriteLine("\t\t\tWelcome to 419 banking applicaton\n");
            Console.WriteLine("Can we know your gender please?\n Mr, Mrs, Miss");
            string gender = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Can we get your first name please?");
            string name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Can we get your last name please?");
            string surname = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Can we get your year of birth(1998) please?");
            int yob = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Can we get your home address please?");
            string addr = (Console.ReadLine());
            Console.Clear();

            Account customer1 = new Account(name, surname, yob, addr, "a12345", 0);

            //Account customer0 = new Account("Babatunde", "Olumoh", 1996, "24 Ajanaku street", "a12345", 0);

            

            
            int i = 0;
            while (i == 0)
            {

                //Menu
                
                Console.WriteLine($"\t\t\tWelcome to 419 banking solution {gender} {surname}\n");
                Console.WriteLine("Our services are: ");
                Console.WriteLine("1: Deposit");
                Console.WriteLine("2: Withdrawal");
                Console.WriteLine("3: Account Statement");
                Console.WriteLine("\nPress 0 to quit");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                     
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Insert amount\n");
                        double deposit = double.Parse(Console.ReadLine());
                        customer1.Deposit(deposit);
                        Console.WriteLine($"Your new balance is now: {customer1.GetBalance()}"); 
                        Console.WriteLine();
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("Insert amount\n");
                        double withdraw = double.Parse(Console.ReadLine());
                        bool isSuccessful = customer1.Withdraw(withdraw);

                        if (isSuccessful)
                        {
                            Console.WriteLine("Withdrawal successful, cash now available, Spend responsibly, Sapa is real!!!\n");
                            Console.WriteLine($"Your new balance is: {customer1.GetBalance()}"); 
                        }
                        else
                        {
                            Console.WriteLine($"Insufficient funds, your current balance is: {customer1.GetBalance()}");
                        }
                        Console.WriteLine();
                        break;

                    case 3:
                        Console.Clear();
                        customer1.Display();
                        Console.WriteLine();
                        break;
                    case 0:
                        i++;
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Bad Input, use the numeric key 1, 2, 3 and 0 to quit");
                        Console.WriteLine();
                        break;
                }

                if (choice == 0)
                {
                    Console.WriteLine("See you again!!!");
                    Thread.Sleep(10);
                    i++;
                }
            }
           
        }
        catch (Exception ex)
        {
            Console.Clear();
            Console.WriteLine("Bad Input!!!");
            Console.WriteLine();
        }
    }
}

