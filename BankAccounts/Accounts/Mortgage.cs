namespace BankAccounts.Accounts
{
    using Customers;
    using Interfaces;

    public class Mortgage : Account, IDepositOperatable
    {
        public Mortgage(Customer owner, int numberOfMonths, double interestRate) : base(owner, numberOfMonths, interestRate)
        {

        }

        public void DepositMoney(decimal deposited)
        {
            base.Balance += deposited;
        }

        public override double InterestAmount()
        {
            if ((base.NumberOfMonths <= 6 && base.Owner is Individual) || (base.NumberOfMonths <= 12 && base.Owner is Company))
            {
                return base.NumberOfMonths * base.InterestRate / 2;
            }
            return base.NumberOfMonths * base.InterestRate;
        }
    }
}
