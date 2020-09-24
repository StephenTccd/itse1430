using System;
using System.Text;

namespace BudgetAccount
{
    public class Account
    {
        public string AccountNumber;
        public string FullName;
        public double Balance;

        public Account ( string account = "", string name = "Stephen Nuguid" )
        {
            AccountNumber = account;
            FullName = name;
            Balance = 0;
        }
    }


    public class Management
    {
        private Account CreateNewAccount ()
        {
            Account client = new Account();

            Console.WriteLine("*******************************************");
            Console.WriteLine("-------------* Budget Bank *--------------");
            Console.WriteLine("-------------------------------------------");
            Console.Write("Enter customer name: ");
            client.FullName = Console.ReadLine();
            Console.Write("Enter a number for the new account: ");
            client.AccountNumber = Console.ReadLine();

            return client;
        }

        public double GetMoney ()
        {
            double amount = 0;

            Console.Write("");
            amount = double.Parse(Console.ReadLine());
            return amount;
        }

        private void ShowAccountInformation ( Account cust )
        {
            Console.WriteLine("*******************************************");
            Console.WriteLine("-------------* Budget Bank *--------------");
            Console.WriteLine("Customer Account Information");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Account #:    {0}", cust.AccountNumber);
            Console.WriteLine("Full Name:    {0}", cust.FullName);
            Console.WriteLine("Balance:      {0:F}", cust.Balance.ToString("C"));
            Console.WriteLine("*******************************************");
            return;
        }

        public static int Main ()
        {
            string description;
            string category;
            double amount;
            int nextAction = 0;
            bool confirmYN;

            Account accountHolder = null;
            Management registration = new Management();

            Console.Title = "Budget Bank";

            accountHolder = registration.CreateNewAccount();
            Console.WriteLine("Enter the customer's initial deposit amount : ");
            accountHolder.Balance = registration.GetMoney();
            Console.Clear();

            registration.ShowAccountInformation(accountHolder);

            do
            {
                Console.WriteLine("What do you want to do now?");
                Console.WriteLine("1 - Add Income");
                Console.WriteLine("2 - Add Expenses");
                Console.WriteLine("3 - Exit");
                Console.Write("Enter your choice: ");
                nextAction = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (nextAction)
                {
                    case 0:
                    Console.Clear();
                    registration.ShowAccountInformation(accountHolder);
                    Console.Write("Press Enter for next operation");
                    Console.ReadKey();
                    break;

                    case 1:
                    Console.Write("Enter amount : ");
                    amount = registration.GetMoney();
                    accountHolder.Balance = accountHolder.Balance + amount;
                    Console.WriteLine("Description (required): ");
                    description = ReadString(true);
                    Console.WriteLine("Category (optional): ");
                    category = ReadString(false);
                    Console.WriteLine(DateTime.Now);
                    Console.WriteLine("Amount successfully added!");

                    Console.Clear();
                    registration.ShowAccountInformation(accountHolder);
                    break;

                    case 2:
                    Console.Write("Enter amount : ");
                    amount = registration.GetMoney();
                    Console.WriteLine("Description (required): ");
                    description = ReadString(true);
                    Console.WriteLine("Category (optional): ");
                    category = ReadString(false);
                    Console.WriteLine(DateTime.Now);
                    if (amount > accountHolder.Balance)
                    {
                        Console.WriteLine("You are not allowed to withdraw more money than your account has.");
                        Console.ReadKey();
                    } else
                        accountHolder.Balance = accountHolder.Balance - amount;
                    Console.WriteLine("Amount successfully deducted!");

                    Console.Clear();
                    registration.ShowAccountInformation(accountHolder);
                    break;

                    case 3:
                    Console.WriteLine("Are you sure to exit? Y/N");
                    confirmYN = GetYorN();
                    break;

                }
                if ((nextAction < 1) || (nextAction > 3))
                    Console.WriteLine(
                    "Invalid Action: Please enter a value between 1 and 3");
            } while ((nextAction >= 1) && (nextAction <= 3));

            Console.ReadKey();
            return 0;

        }
        static string ReadString ( bool required )
        {
            do
            {
                string value = Console.ReadLine();

                if (!required || value != "")
                    return value;

                DisplayError("Please enter description");
            } while (true);
        }
        static bool GetYorN ()
        {
            do
            {
                ConsoleKeyInfo key = Console.ReadKey();
                switch (key.Key)
                {
                    case ConsoleKey.Y: return true;
                    case ConsoleKey.N: return false;
                };
            } while (true);

        }
        private static void DisplayError ( string message )
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine(message);

            Console.ResetColor();
        }
    }
}
