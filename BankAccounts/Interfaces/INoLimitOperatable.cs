namespace BankAccounts.Interfaces
{
    public interface INoLimitOperatable : IDepositOperatable
    {
        void WithDrawMoney(decimal withDrawn);
    }
}
