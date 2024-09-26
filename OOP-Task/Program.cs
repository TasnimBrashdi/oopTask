namespace OOP_Task
{
    public class Program
    {
        private static Bank Bank = new Bank();
        static void Main(string[] args)
        {
           bool runn=true;
            try
            {
                while (runn)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;

                    Console.WriteLine("- - - WELCOME TO BANK SYSTEM - - -");
                    Console.WriteLine("- 1 -Add Account -");
                    Console.WriteLine("- 2- Display All Accounts -");
                    Console.WriteLine("- 3- deposit  -");
                    Console.WriteLine("- 4- Withdraw  -");
                    Console.WriteLine("- 5- Exit  -");
                    Console.WriteLine("\n-  Enter yOur Chooice  -");
                    int c = int.Parse(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.White;
                    switch (c)
                    {

                        case 1:

                            Console.WriteLine("Enter AccOunt NumBer");
                            string accountNumber = Console.ReadLine();

                            Console.WriteLine("Enter AccOunt name");
                            string Holdername = Console.ReadLine();
                           
                            Bank.AddAccount(new BankAccount( accountNumber, Holdername));
                            break;
                        case 2:

                            Bank.DisplayAllAccounts();
                            break;
                       
                        case 3:

                            Console.WriteLine("Enter number account");
                            string accountN = Console.ReadLine();
                            Console.WriteLine("Enter number of money");
                            decimal m = decimal.Parse(Console.ReadLine());
                            BankAccount account = Bank.GetAccountByNumber(accountN);
                            account.deposit(m);

                            break;
                        case 4:
                            Console.WriteLine("Enter number account");
                            string accountNw = Console.ReadLine();
                            
                            Console.WriteLine("Enter number of money");
                            decimal num = decimal.Parse(Console.ReadLine());

                            BankAccount accountw = Bank.GetAccountByNumber(accountNw);
                            accountw.Withdraw(num);
                            break;
                        case 5:
                            runn = false;
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("INVAILD INPUT");
                            break;

                    }
                }
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERROR" + ex.Message);
            }






        }
    }

}
