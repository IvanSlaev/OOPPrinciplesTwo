using System;
using BankAccounts.Interfaces;

namespace BankAccounts.Accounts
{
    using BankAccounts.Customers;

    public abstract class Account
    {
        protected Account(Customer owner, int numberOfMonths, double interestRate)
        {
            this.Owner = owner;
            this.NumberOfMonths = numberOfMonths;
            this.InterestRate = interestRate;
        }

        public Customer Owner { get; protected set; }

        public decimal Balance { get; protected set; }

        public int NumberOfMonths { get; protected set; }

        public double InterestRate { get; protected set; }

        public abstract double InterestAmount();
    }
}
