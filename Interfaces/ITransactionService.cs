namespace BankApplication
{
    public interface ITransactionService
    {
         void DepositToAccount(IAccount account, decimal amountToDeposit);
         void WithdrawAmount(IAccount account, decimal amountToWithdraw);
         void TransferAount (IAccount fromAccount, IAccount toAccount, decimal amountToTransfer);
    }
}