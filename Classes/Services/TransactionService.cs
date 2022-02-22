namespace BankApplication
{
    public class TransactionService : ITransactionService
    {
        public void DepositToAccount(IAccount account, decimal amountToDeposit)
        {
            account.Deposit(amountToDeposit);
        }

        public void WithdrawAmount(IAccount account, decimal amountToWithdraw)
        {
            account.Withdraw(amountToWithdraw);
        }

        public void TransferAount(IAccount fromAccount, IAccount toAccount, decimal amountToTransfer)
        {
            //what if from account donm't have enough balance or hit withdrawal limit
            //only add to ToAccount if FromAccount withdraw compltes
            fromAccount.Withdraw(amountToTransfer);
            toAccount.Deposit(amountToTransfer);
        }
    }
}