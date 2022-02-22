namespace BankApplication
{
    public interface IInvestmentAccount : IAccount
    {
         decimal WithdrawalLimit {get; set;}
    }
}