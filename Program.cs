using System;

namespace BankApplication
{
    public class Program
    {
        static void Main(string[] args)
        {
            ITransactionService transactionService = new TransactionService();

            Bank bank = new Bank() { Name = "Chase Bank" };

            //Create individual account (chekcing, investment)
            Owner individualOwner = new Owner() { Name = "John Doe", Address = "Test St, Test City, Test State, 95067" };
            CheckingAccount individualCheckingAccount = new CheckingAccount(){ AccountOwner = individualOwner, Balance = 1000 };
            IndividualInvestmentAccount individualInvestmentAccount = new IndividualInvestmentAccount() { AccountOwner = individualOwner, Balance = 10000 };
            
            //Coorporate account
            Owner coorporateOwner = new Owner() { Name = "Apple. Inc", Address = "123 Silicon Valley, San Fransisco, California, 90056" };
            CheckingAccount coorporateCheckingAccount = new CheckingAccount(){ AccountOwner = coorporateOwner, Balance = 10000 };
            CorporateInvestmentAccount corporateInvestmentAccount = new CorporateInvestmentAccount() { AccountOwner = coorporateOwner, Balance = 100000};

            //Test Individual Account functionality
            Console.WriteLine("Testing checking account depoisit");
            Console.WriteLine($"Current Balance: {individualCheckingAccount.Balance}");

            //Indivisual deposit
            transactionService.DepositToAccount(individualCheckingAccount, 500);
            Console.WriteLine($"Current Balance: {individualCheckingAccount.Balance}");

            //Indivisual withdraw
            transactionService.WithdrawAmount(individualCheckingAccount, 400);
            Console.WriteLine($"Current Balance after Withdrawal: {individualCheckingAccount.Balance}");

            //transfer from corporate to indivisual
            transactionService.TransferAount(coorporateCheckingAccount, individualCheckingAccount, 400);
            Console.WriteLine($"Current Balance after transfer: {individualCheckingAccount.Balance}");


            //Test Coorporate account
            Console.WriteLine("Testing corporate account deposit");
            Console.WriteLine($"Current Balance: {coorporateCheckingAccount.Balance}");

            // Coorporate deposit
            transactionService.DepositToAccount(coorporateCheckingAccount, 500);
            Console.WriteLine($"Current Balance: {coorporateCheckingAccount.Balance}");

            //Coorporate withdraw
            transactionService.WithdrawAmount(coorporateCheckingAccount, 200);
            Console.WriteLine($"Current Balance after Withdrawal: {coorporateCheckingAccount.Balance}");

            //Coorporate indivisaul to coorporate 
            transactionService.TransferAount(individualCheckingAccount, coorporateCheckingAccount, 20);
            Console.WriteLine($"Current Balance after transfer: {coorporateCheckingAccount.Balance}");
        }
    }
}
