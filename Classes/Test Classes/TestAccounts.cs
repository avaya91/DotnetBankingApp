using System;

namespace BankApplication.Classes.Test_Classes
{
    public class TestDepositAndWithdrawal
    {
        private IAccount Account{get; set;}
        private ITransactionService TransactionService{get; set;}
        public TestDepositAndWithdrawal(IAccount account)
        {
            this.Account = account;
            
            //intialize transaction service, best practise is to use dependancy injection here
            //but it's outside the scope of this assignment
            this.TransactionService = new TransactionService(Account);
        }

        public bool Deposit(decimal amountToDeposit)
        {
            Console.WriteLine("Testing account deposit");
            Console.WriteLine($"Current Balance: {Account.Balance}");

            //Indivisual deposit
            TransactionService.DepositToAccount(amountToDeposit);
            Console.WriteLine($"Balance After Deposit: {Account.Balance}");

            return true;
        }

        public bool Withdrawal(decimal amountToWithdraw)
        {
            Console.WriteLine("Testing account withdrawal");
            Console.WriteLine($"Current Balance: {Account.Balance}");

            //Indivisual deposit
            TransactionService.WithdrawAmount(amountToWithdraw);
            Console.WriteLine($"Balance After Withdrawal: {Account.Balance}");

            return true;
        }

        public bool WithdrawalCorp(decimal amountToWithdraw)
        {
            Console.WriteLine("Testing account withdrawal");
            Console.WriteLine($"Current Balance: {Account.Balance}");

            //Indivisual deposit
            TransactionService.WithdrawAmount(amountToWithdraw);
            Console.WriteLine($"Balance After Withdrawal: {Account.Balance}");

            return true;
        }
    }

    public class TestTransfer
    {
        private IAccount FromAccount{get; set;}
        private IAccount ToAccount{get; set;}
        private ITransactionService TransactionService{get; set;}

        public TestTransfer(IAccount fromAccount, IAccount toAccount)
        {
            this.FromAccount = fromAccount;
            this.ToAccount = toAccount;
            this.TransactionService = new TransactionService(this.FromAccount, this.ToAccount);
        }

        public bool TransferBetweenAccounts(decimal amountToTransfer)
        {
            Console.WriteLine("Testing account withdrawal");
            Console.WriteLine($"Current Balance of account to transfer from: {FromAccount.Balance}");
            Console.WriteLine($"Current Balance of account to transfer into: {ToAccount.Balance}");
            TransactionService.TransferAmount(amountToTransfer);

            Console.WriteLine($"Balance of account to transfer from (after transfer): {FromAccount.Balance}");
            Console.WriteLine($"Balance of account to transfer into (after transfer): {ToAccount.Balance}");
            return true;
        }
    }
}