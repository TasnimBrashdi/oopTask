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
    }
    

}
