using System;
using BankApplication.Classes.Test_Classes;
using BankApplication.Classes.Bank_Objects;
namespace BankApplication
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Create in memory bank object with individual and coorporate accounts
            Bank testBank = BankRepository.CreateBank();

            //Create accounts
            AccountModel individualAccountModel = BankRepository.GetNewIndividualAcount();
            AccountModel coorporateAccountModel = BankRepository.GetNewCoorporateAccount();

            testBank.Accounts.Add(individualAccountModel.CheckingAccount);
            testBank.Accounts.Add(individualAccountModel.InvestmentAccount);
            testBank.Accounts.Add(coorporateAccountModel.CheckingAccount);
            testBank.Accounts.Add(coorporateAccountModel.InvestmentAccount);

            Console.WriteLine($"Bank Name: {testBank.Name}");
            Console.WriteLine($"Number of accounts in Bank: {testBank.Accounts.Count}");

            //Test individual account
            TestDepositAndWithdrawal testIndividualAccount = new TestDepositAndWithdrawal(individualAccountModel.CheckingAccount);
            testIndividualAccount.Deposit(500);
            testIndividualAccount.Withdrawal(600);
            
            TestTransfer testTransferFromCheckingToInvestment = new TestTransfer(individualAccountModel.CheckingAccount, individualAccountModel.InvestmentAccount);
            testTransferFromCheckingToInvestment.TransferBetweenAccounts(500);


            //Test Coorporate account
            TestDepositAndWithdrawal testCorporateAccount = new TestDepositAndWithdrawal(coorporateAccountModel.CheckingAccount);
            testCorporateAccount.Deposit(200);
            testCorporateAccount.WithdrawalCorp(500);
            
            TestTransfer testTransferFromInvestmentToChecking = new TestTransfer(individualAccountModel.InvestmentAccount, individualAccountModel.CheckingAccount);
            testTransferFromInvestmentToChecking.TransferBetweenAccounts(100);
        }
    }
}
