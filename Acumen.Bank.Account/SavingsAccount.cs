using System;

namespace Acumen.Bank.Account
{
    public class SavingsAccount
    {
        public string OwnerName { get; private set; }
        public double Balance { get; private set; }
        //declaring the variable 
        public double Interest { get; private set; }

        //added the instance with a 3rd parameter of interest
        public SavingsAccount(string ownerName, double balance, double interest)
        {
            this.OwnerName = ownerName;
            this.Balance = balance;
            this.Interest = interest;
        }

        public void Deposit(double amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Cannot deposit a negative amount");
            }
            this.Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Cannot withdraw a negative amount");
            }
            this.Balance -= amount;
        }

        public void Transfer(SavingsAccount destinationAccount, double amount)
        {
            destinationAccount.Deposit(amount);
            //invoking the withdraw method updates the Current balance after transfer
            this.Withdraw(amount);

        }

        //Adding an interest method to calclate the interest 
        public void applyInterest(int years)
        {
            this.Balance = this.Balance * (1 + this.Interest) * years;


        }


    }
}
