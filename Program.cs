using BankStuffLibrary;
using System;


namespace MySuperBank
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Sedat", 10000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance}");
            account.MakeWithdrawal(50, DateTime.Now, "Coffee");
            account.MakeWithdrawal(5, DateTime.Now, "Tea");
            account.MakeWithdrawal(120, DateTime.Now, "Food");


            Console.WriteLine(account.Balance);

            //account.MakeWithdrawal(-3000000, DateTime.Now, "coba mencuri");

            

            // Test that the initial balances must be positive.
            //try
            //{
            //    var invalidAccount = new BankAccount("Reni", -1000000);
            //}
            //catch (ArgumentOutOfRangeException e)
            //{
            //    Console.WriteLine("Exception caught creating account with negative balance");
            //    Console.WriteLine(e.ToString());
            //}

            // account.MakeWithdrawal(50000, DateTime.Now, "beli pizza");
            // Console.WriteLine(account.Balance);

            Console.WriteLine(account.GetAccountStory());
        }
    }
}
