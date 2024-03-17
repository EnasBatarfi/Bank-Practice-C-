using System;

class Bank
{
    public static void Main(string[] args)
    {
        User[] users = { new User("Enas Batarfi", 1, 23, 53987), new User("Ahmed Mohammed", 2, 33, 500) };
        Console.WriteLine("----------------------------------------\nWelcome to Our Bank\n----------------------------------------");
        Console.Write("Please Enter Your ID: ");
        int id;
        while (!int.TryParse(Console.ReadLine(), out id))
        {
            Console.Write("Invalid ID. Please enter a valid ID: ");
        }
        User? foundedUser = Array.Find(users, user => user.GetId() == id);
        if (foundedUser != null)
        {
            Console.WriteLine($"Welcome, {foundedUser.GetName()}!");
            while (true)
            {
                Console.WriteLine("\nPlease Choose the transaction you want to perform:");
                Console.WriteLine("\t1-Deposit\n\t2-Withdraw\n\t3-Check Balance\n\t4-Exit");
                int choice;
                while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 4)
                {
                    Console.Write("Invalid choice. Please enter a number between 1 and 4: ");
                }

                switch (choice)
                {
                    case 1:
                        Deposit(foundedUser);
                        DisplayBalance(foundedUser);
                        break;
                    case 2:
                        Withdraw(foundedUser);
                        DisplayBalance(foundedUser);
                        break;
                    case 3:
                        DisplayBalance(foundedUser);
                        break;
                    case 4:
                        Console.WriteLine("Thank you for using our bank.");
                        Environment.Exit(0);
                        break;
                }
            }
        }
        else
        {
            Console.WriteLine("Authentication Failed. Thank you for using our bank");
        }
    }

    public static void Deposit(User user)
    {
        Console.Write("\nEnter the deposit amount: ");
        int amount;
        while (!int.TryParse(Console.ReadLine(), out amount) || amount <= 0)
        {
            Console.Write("Invalid amount. Please enter a valid positive amount: ");
        }
        user.SetBalance(user.GetBalance() + amount);
        Console.WriteLine("Deposit successful.");
    }

    public static void Withdraw(User user)
    {
        Console.Write("\nEnter the withdrawal amount: ");
        int amount;
        while (!int.TryParse(Console.ReadLine(), out amount) || amount <= 0)
        {
            Console.Write("Invalid amount. Please enter a valid positive amount: ");
        }
        if (amount <= user.GetBalance())
        {
            user.SetBalance(user.GetBalance() - amount);
            Console.WriteLine("Withdrawal successful.");
        }
        else
        {
            Console.WriteLine("Insufficient balance.");
        }
    }

    public static void DisplayBalance(User user)
    {
        double balance = user.GetBalance();
        Console.WriteLine($"----------------------------------------\nYour current balance is {balance} SAR\n----------------------------------------");
    }

    public static void UserInformation(User user)
    {
        string name = user.GetName();
        int age = user.GetAge();
        int id = user.GetId();
        double balance = user.GetBalance();

        Console.WriteLine("User Information:");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"ID: {id}");
        Console.WriteLine($"Balance: ${balance:F2}");

    }
}