using System;
namespace BankApplication
{
    public class TransactionService : ITransactionService
    {
        private IAccount Account {get; set;}
        private IAccount FromAccount {get; set;}
        private IAccount ToAccount {get; set;}

        //constructor based on passed parameter
        public TransactionService(IAccount account)
        {
            this.Account = account;
        }
        public TransactionService(IAccount fromAccount, IAccount toAccount)
        {
            this.FromAccount = fromAccount;
            this.ToAccount = toAccount;
        }
        public void DepositToAccount(decimal amountToDeposit)
        {
            Account.Deposit(amountToDeposit);
        }

        public void WithdrawAmount(decimal amountToWithdraw)
        {
            if (amountToWithdraw <= Account.Balance)
            {
                Account.Withdraw(amountToWithdraw);
            }
            else
            {
                Console.WriteLine("Not enough balance in account to withdraw");
            }
                
        }

        public void TransferAmount(decimal amountToTransfer)
        {
            //what if from account donm't have enough balance or hit withdrawal limit
            //only add to ToAccount if FromAccount withdraw compltes
            if (amountToTransfer <= FromAccount.Balance)
            {
                FromAccount.Withdraw(amountToTransfer);
                ToAccount.Deposit(amountToTransfer);
            }
            else
            {
                Console.WriteLine("Not enough balance in account to transfer");
            }
            
        }
    }
}