namespace BankApplication
{
    public interface ITransactionService
    {
         void DepositToAccount(decimal amountToDeposit);
         void WithdrawAmount(decimal amountToWithdraw);
         void TransferAmount (decimal amountToTransfer);
    }
}