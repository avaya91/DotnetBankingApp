using System.Collections.Generic;
using BankApplication.Classes.Bank_Objects;
namespace BankApplication.Classes.Test_Classes
{
    public class BankRepository
    {
        public static Bank CreateBank()
        {
            //Create bank
            Bank bank = new Bank() { Name = "Chase Bank" , Accounts = new List<IAccount>()};  
            return bank;
        }

        public static AccountModel GetNewIndividualAcount()
        {
            //Create individual account (chekcing, investment)
            AccountModel newIndividualAccount = new AccountModel(); 
            
            Owner individualOwner = new Owner() { Name = "John Doe", Address = "Test St, Test City, Test State, 95067" };
            CheckingAccount individualCheckingAccount = new CheckingAccount(){ AccountOwner = individualOwner, Balance = 1000 };
            IndividualInvestmentAccount individualInvestmentAccount = new IndividualInvestmentAccount() { AccountOwner = individualOwner, Balance = 10000 };
            
            newIndividualAccount.AccountOwner = individualOwner;
            newIndividualAccount.CheckingAccount = individualCheckingAccount;
            newIndividualAccount.InvestmentAccount = individualInvestmentAccount;

            return newIndividualAccount;
        }

        public static AccountModel GetNewCoorporateAccount()
        {
            AccountModel newCoorporateAccount = new AccountModel();

            Owner coorporateOwner = new Owner() { Name = "Apple. Inc", Address = "123 Silicon Valley, San Fransisco, California, 90056" };
            CheckingAccount coorporateCheckingAccount = new CheckingAccount(){ AccountOwner = coorporateOwner, Balance = 100000 };
            CorporateInvestmentAccount corporateInvestmentAccount = new CorporateInvestmentAccount() { AccountOwner = coorporateOwner, Balance = 100000};

            newCoorporateAccount.AccountOwner = coorporateOwner;
            newCoorporateAccount.CheckingAccount = coorporateCheckingAccount;
            newCoorporateAccount.InvestmentAccount = corporateInvestmentAccount;

            return newCoorporateAccount;
        }
    }
}