/*
 * Stephen Nuguid
 * ITSE 1430
 * Lab 1
 */
using System;
using System.Text;

namespace BankAccount
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
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("-------------* Budget Bank *--------------");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("*******************************************");
            Console.Write("Enter customer name: ");
            client.FullName = ReadName(true);
            Console.Write("Enter a number for the new account: ");
            client.AccountNumber = ReadAccountNum(true);

            return client;
        }
        static string ReadName ( bool required )
        {
            do
            {
                string value = Console.ReadLine();

                if (!required || value != "")
                    return value;

                DisplayError("Please enter name");
            } while (true);
        }
        static string ReadAccountNum ( bool required )
        {
            do
            {
                string value = Console.ReadLine();

                if (!required || value != "")
                    return value;

                DisplayError("Please enter valid number");
            } while (true);
        }
        public double GetMoney ()
        {
            double amount = 0;

            Console.Write("");
            amount = Double.Parse(Console.ReadLine());
            return amount;
        }

        private void ShowAccountInformation ( Account cust )
        {
            Console.WriteLine("*******************************************");
            Console.WriteLine("-------------* Budget Bank *--------------");
            Console.WriteLine("Customer Account Information");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Full Name:    {0}", cust.FullName);
            Console.WriteLine("Account #:    {0}", cust.AccountNumber);
            Console.WriteLine("Balance:      {0:F}", cust.Balance.ToString("C"));
            Console.WriteLine("*******************************************");
            return;
        }

        public static int Main ()
        {
            string description;
            string category;
            double amount;
            int response = 0;

            Account accountHolder = null;
            Management registration = new Management();

            Console.Title = "Budget Bank";

            accountHolder = registration.CreateNewAccount();
            Console.Write("Enter the customer's initial deposit amount : ");
            accountHolder.Balance = registration.GetMoney();
            Console.Clear();

            registration.ShowAccountInformation(accountHolder);

            do
            {
                Console.WriteLine("What do you want to do now?");
                Console.WriteLine("1. - Add Income");
                Console.WriteLine("2. - Add Expenses");
                Console.WriteLine("3. - Exit");
                Console.Write("Enter your choice: ");
                response = Int32.Parse(Console.ReadLine());
                Console.Clear();

                switch (response)
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
                    if (amount < 0)
                    {
                        Console.WriteLine("You are not allowed to put money below $0.");
                        Console.ReadLine();
                        Console.Clear();
                        registration.ShowAccountInformation(accountHolder);
                        break;
                    } else
                        accountHolder.Balance = accountHolder.Balance + amount;
                    Console.Write("Description (required): ");
                    description = ReadString(true);
                    Console.Write("Category (optional): ");
                    category = ReadString(false);
                    Console.WriteLine(DateTime.Now.ToString("MM/dd/yyyy"));
                    Console.WriteLine("\n\nAmount successfully added!");
                    Console.ReadLine();

                    Console.Clear();
                    registration.ShowAccountInformation(accountHolder);
                    break;

                    case 2:
                    Console.Write("Enter amount : ");
                    amount = registration.GetMoney();
                    Console.Write("Description (required): ");
                    description = ReadString(true);
                    Console.Write("Category (optional): ");
                    category = ReadString(false);
                    Console.WriteLine(DateTime.Now.ToString("MM/dd/yyyy"));
                    if (amount > accountHolder.Balance)
                    {
                        Console.WriteLine("You are not allowed to spend more money than your account has.");
                        Console.ReadLine();
                        Console.Clear();
                        registration.ShowAccountInformation(accountHolder);
                        break;
                    } else
                        accountHolder.Balance = accountHolder.Balance - amount;
                    Console.WriteLine("\n\nAmount successfully deducted!");
                    Console.ReadLine();

                    Console.Clear();
                    registration.ShowAccountInformation(accountHolder);
                    break;

                    case 3:
                    Console.WriteLine("Are you sure to exit? [Y/N]");
                    return 0;


                }
                if ((response < 1) || (response > 3))
                    Console.WriteLine("Invalid Action: Please enter a value between 1 and 3");
            } while ((response >= 1) && (response <= 3));

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
        
        private static void DisplayError ( string message )
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine(message);

            Console.ResetColor();
        }
        
    }
}