using System.Collections.Generic;

namespace BankApplication
{
    public class Bank
    {
        public string Name {get; set;}
        public List<IAccount> Accounts {get; set;}
    }
}