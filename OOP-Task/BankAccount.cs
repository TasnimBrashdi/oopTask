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
        private string AccountNumber { get; set; }
        private string AccountHolderName { get;  set; }
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

            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine("Deposited, Your balance: " + Balance);
            }
            else
            {
                Console.WriteLine("ERROR: deposit amount must be positive!");
            }
           

        }
        public void Withdraw(decimal amount) {
            if (amount > 0 && amount <= Balance)
            {
                Balance -= amount;

                Console.WriteLine($"Successfully withdrew {amount} OMR. YOur balance  is {Balance} OMR");

            }
            else {
                Console.WriteLine("insufficient Balance to complete the transaction");
            }
        
        }
        public void GetAccountInfo() {
            Console.WriteLine("\n- - - - ACCOUNT INFORMATION - - - -");
            Console.WriteLine("\nAccount Number: "+ AccountNumber);

            Console.WriteLine("\nAccount Holder Name: " + AccountHolderName);

            Console.WriteLine("\nBalance: "+ Balance);
        }
        public string GetAccountNumber()
        {
            return $"{AccountNumber}";
        }

    }
    

}
