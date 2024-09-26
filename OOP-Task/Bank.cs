using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Task
{
    public class Bank
    {
        public List<BankAccount> AccountList = new List<BankAccount>();
        public Bank() {

            AccountList.Add(new BankAccount( "325632435","Ahmed Ali", 12));
            AccountList.Add(new BankAccount( "325625634", "Noor Hamed"));
            AccountList.Add(new BankAccount("325625634","Fatma Khlid"));
            AccountList.Add(new BankAccount("325625098","Salim Omr", 100));



        }
        public void AddAccount(BankAccount account) {
            AccountList.Add(account);

            Console.WriteLine("Account Added");
        }
        public void DisplayAllAccounts() {

            foreach (var acc in AccountList) {
                acc.GetAccountInfo();
            }

        }
        public BankAccount GetAccountByNumber(string accountNumber)
        {
            foreach (BankAccount account in AccountList)
            {
                if (account.GetAccountNumber()== accountNumber)
                { return account; }
            }
            Console.WriteLine("Account not found!");
            return null;
        }

    } }
