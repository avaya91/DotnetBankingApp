namespace BankApplication
{
    public interface IAccount
    {
        Owner AccountOwner {get; set;}
        decimal Balance {get; set;}
        void Deposit(decimal amountToDeposit);
        void Withdraw(decimal amountToWithdraw);

    }
}