namespace OOP_Task
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("- - - WELCOME TO BANK SYSTEM - - -");
            Console.WriteLine("- 1-Add Account -");
            Console.WriteLine("- 2-Display All Accounts -");
            Console.WriteLine("- 3-Get Account By Number  -");
            Console.WriteLine("- 4-deposit  -");
            Console.WriteLine("- 5-Withdraw  -");
            Console.WriteLine("\n-Enter yOur Chooice -");
            int c=int.Parse(Console.ReadLine());

            switch (c) { 
                    case 1:
                    Bank adding =new Bank();
                    adding.AddAccount();
                    break;
                    case 2:
                    Bank d = new Bank();
                    d.DisplayAllAccounts();
                    break;
                    case 3:
                    Console.WriteLine("Enter number account");
                    string accountNumber = Console.ReadLine();
                    Bank g = new Bank();
                    g.GetAccountByNumber(accountNumber);
                    break;
                    case 4:
                    Console.WriteLine("Enter number account");
                    string accountN = Console.ReadLine();
                    Console.WriteLine("Enter NAME account");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter number of money");
                    decimal m =decimal.Parse( Console.ReadLine());

                    BankAccount dep = new BankAccount(name,accountN);    
                    dep.deposit(m);
                    break;
                    case 5:
                    Console.WriteLine("Enter number account");
                    string accountNw = Console.ReadLine();
                    Console.WriteLine("Enter NAME account");
                    string namew = Console.ReadLine();
                    Console.WriteLine("Enter number of money");
                    decimal num = decimal.Parse(Console.ReadLine());

                    BankAccount w = new BankAccount(namew, accountNw);
                    w.Withdraw(num);
                    break;
                    default:

                    Console.WriteLine("INVAILD INPUT");
                    break;
            
            }






        }
    }

}
