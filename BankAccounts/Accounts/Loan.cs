namespace BankAccounts.Accounts
{
    using Customers;
    using Interfaces;

    public class Loan : Account, IDepositOperatable
    {
        public Loan(Customer owner, int numberOfMonths, double interestRate) : base(owner, numberOfMonths, interestRate)
        {

        }

        public void DepositMoney(decimal deposited)
        {
            base.Balance += deposited;
        }

        public override double InterestAmount()
        {
            if ((base.NumberOfMonths <= 3 && base.Owner is Individual) || (base.NumberOfMonths <= 2 && base.Owner is Company))
            {
                return 0;
            }
            return base.NumberOfMonths * base.InterestRate;
        }
    }
}
