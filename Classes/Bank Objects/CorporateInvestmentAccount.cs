namespace BankApplication
{
    public class CorporateInvestmentAccount : IAccount
    {
        public Owner AccountOwner {get; set;}
        public decimal Balance {get; set;}

        public void Deposit(decimal amountToDeposit)
        {
            this.Balance += amountToDeposit;
        }

        public void Withdraw(decimal amountToWithdraw)
        {
            this.Balance -= amountToWithdraw;
        }

        public void WithdrawCorp(decimal amountToWithdraw)
        {
            this.Balance -= amountToWithdraw;
        }
    }
}