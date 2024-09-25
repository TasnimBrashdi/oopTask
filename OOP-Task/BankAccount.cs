using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Task
{
    public class BankAccount
    {
        private string AccountNumber;
        private string AccountHolderName;
        private decimal Balance;
     public BankAccount(string accountNumber, string accountHolderName)
        {
            AccountNumber = accountNumber;
            AccountHolderName= accountHolderName;
        }
      public BankAccount(string accountNumber,string accountHolderName,decimal deposit) {

            AccountNumber = accountNumber;
            AccountHolderName = accountHolderName;
            Balance = deposit;

        }
    }
    

}
