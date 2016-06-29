namespace BankAccounts.Accounts
{
    using Customers;
    using Interfaces;

    public class Deposit : Account , INoLimitOperatable
    {
        public Deposit(Customer owner, int numberOfMonths, double interestRate) : base(owner, numberOfMonths, interestRate)
        {

        }

        public void DepositMoney(decimal deposited)
        {
            base.Balance += deposited;
        }

        public void WithDrawMoney(decimal withDrawn)
        {
            base.Balance -= withDrawn;
        }

        public override double InterestAmount()
        {
            if (base.Balance > 0 && base.Balance < 1000)
            {
                return 0;
            }
            return base.NumberOfMonths * base.InterestRate;
        }
    }
}
