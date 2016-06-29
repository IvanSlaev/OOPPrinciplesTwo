namespace BankAccounts.Customers
{
    public abstract class Customer
    {
        protected Customer(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName { get; protected set; }

        public string LastName { get; protected set; }
    }
}
