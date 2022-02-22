namespace BankApplication.Classes.Bank_Objects
{
    public class AccountModel
    {
        public Owner AccountOwner{get; set;}
        public IAccount CheckingAccount {get; set;}
        public IAccount InvestmentAccount {get; set;}
    }
}