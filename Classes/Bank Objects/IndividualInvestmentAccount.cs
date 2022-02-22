using System;
namespace BankApplication
{
    public class IndividualInvestmentAccount : IAccount
    {
        public Owner AccountOwner {get; set;}
        public decimal Balance {get; set;}
        public decimal WithdrawalLimit{get => WithdrawalLimit; set => WithdrawalLimit = 500;}

        public void Deposit(decimal amountToDeposit)
        {
            this.Balance += amountToDeposit;
        }

        public void Withdraw(decimal amountToWithdraw)
        {
            if (amountToWithdraw <= WithdrawalLimit){
                this.Balance -= amountToWithdraw;
            }
            else
            {
                Console.WriteLine("Amount to withdraw exceeds withdrawal limit");
            }
        }
        public void WithdrawCorp(decimal amountToWithdraw)
        {
            this.Balance -= amountToWithdraw;
        }

    }
}