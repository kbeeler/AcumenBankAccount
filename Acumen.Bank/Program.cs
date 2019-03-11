using System;
using System.Threading;
using Acumen.Bank.Account;


namespace Acumen.Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Acumen Bank!");
		    Console.WriteLine();
            //new bank accounts created 
		    CheckingAccount michaelsAccount = new CheckingAccount("Michael", 5000);
		    CheckingAccount gobsAccount = new CheckingAccount("Gob", 2000);

		    Console.WriteLine("Open Accounts:");
		    Console.WriteLine();
		    PrintAccountDetails(michaelsAccount);
		    Console.WriteLine();
		    PrintAccountDetails(gobsAccount);

            //Making a money transfer 
		    Console.WriteLine();
		    Console.WriteLine("Making transfer of $1000.00...");
            try
            {
                Thread.Sleep(500);
            }
            catch (ThreadInterruptedException)
            {
                return;
            }

		    michaelsAccount.Transfer(gobsAccount, 1000);

		    Console.WriteLine("Updated Account Details:");
		    Console.WriteLine();
		    PrintAccountDetails(michaelsAccount);
		    Console.WriteLine();
		    PrintAccountDetails(gobsAccount);

        


            //code for savings account implementation

            // Initialize new savings account with initial balance of $30,000 and 0.89% interest

            //Creating new customer accounts
            Console.WriteLine("New Savings Accounts: Ace and Gary!!! ");
            Console.WriteLine();

            SavingsAccount acesSavingsAccount = new SavingsAccount("Ace", 30000, .0089);
            SavingsAccount garysSavingsAccount = new SavingsAccount("Gary", 10000, .0056);

            //Printing the Name and the current balance of each account 
            Console.WriteLine("Current balance For: Ace and Gary: ");

            Console.WriteLine("Balance of " + acesSavingsAccount.OwnerName + "'s savings account: $" + acesSavingsAccount.Balance);          
            Console.WriteLine("Balance of " + garysSavingsAccount.OwnerName + "'s savings account: $" + garysSavingsAccount.Balance);
            Console.WriteLine();

            //Showing the balance of the accounts after transfer has been made
            Console.WriteLine("Account balance after Ace Makes a money transfers of $5000 to Gary:");
            acesSavingsAccount.Transfer(garysSavingsAccount, 5000);
            Console.WriteLine("Balance of " + acesSavingsAccount.OwnerName + "'s savings account: $" + acesSavingsAccount.Balance);          
            Console.WriteLine("Balance of " + garysSavingsAccount.OwnerName + "'s savings account: $" + garysSavingsAccount.Balance);
            Console.WriteLine();

            // apply 2 years of interest to the savings accounts
            Console.WriteLine("After Two Years of Interest:");
            acesSavingsAccount.applyInterest(2);
            garysSavingsAccount.applyInterest(2);

            Console.WriteLine("Balance + Interest accumulated for " + acesSavingsAccount.OwnerName + "'s savings account: $" + acesSavingsAccount.Balance);
            Console.WriteLine("Balance + Interest accumulated for " + garysSavingsAccount.OwnerName + "'s savings account: $" + garysSavingsAccount.Balance);
            Console.WriteLine();
            Console.ReadLine();
        }

	    private static void PrintAccountDetails(CheckingAccount account) {
		    Console.WriteLine("Account for {0}:\r\n", account.OwnerName);
            Console.WriteLine("Balance: {0:C2}\r\n", account.Balance);
	    }


    }
}
