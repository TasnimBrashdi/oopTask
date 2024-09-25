using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Task
{
    public class BankAccount
    {
        private string AccountNumber;
        private string AccountHolderName;
        public decimal Balance { get; private set; }
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
        public void deposit(decimal amount) {  

            Balance += amount;
            Console.WriteLine("Deposited"); 

        }
        public void Withdraw(decimal amount) {
            if (Balance >= amount)
            {
                Balance -= amount;


            }
            else {
                Console.WriteLine("insufficient Balance to complete the transaction");
            }
        
        }
        public void GetAccountInfo(string accountNumber,string accountHolderName,decimal balance) {
            Console.WriteLine("- - - - ACCOUNT INFORMATION - - - -");
            Console.WriteLine("Account Number: "+accountNumber);

            Console.WriteLine("Account Holder Name: " + accountHolderName);

            Console.WriteLine("Balance: "+ balance);
        }

    }
    

}
