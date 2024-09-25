using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Task
{
    internal class Bank
    {
        public List<BankAccount> AccountList = new List<BankAccount>();
        public void AddAccount(BankAccount account) {

            AccountList.Add(account);


        }
        public void DisplayAllAccounts() { 
        
        
        }
        public void GetAccountByNumber(BankAccount number) { 

        
        }

    }
}
