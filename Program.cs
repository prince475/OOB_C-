using System;

namespace MySuperBank
{
    class Program
    {
        static void Main(string[] args)
        {
           var account = new BankAccount("Bree", 10000);
           Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance}");

           account.MakeWithdrawal(1200, DateTime.Now, "Ring");
           // Console.WriteLine(account.Balance);
           account.MakeWithdrawal(500, DateTime.Now, "Flowers");
           // Console.WriteLine(account.Balance);

           // Account history

           Console.WriteLine(account.GetAccountHistory());


           // Catching an Exception
           // Testing the initial balance must be positive

        //    try
        //    {
        //         var invalidAccount = new BankAccount("Invalid", -560);
        //    }
        //    catch (ArgumentOutOfRangeException e)
        //    {
        //     Console.WriteLine("Exception caught creating account with negative balance");
        //     Console.WriteLine(e.ToString());
        //    }

           // Testing for negative balances overdraws

        //    try
        //    {
        //         account.MakeWithdrawal(75000, DateTime.Now, "Attempt to overdraw the account");
        //    }
        //    catch (InvalidOperationException e)
        //    {
        //     Console.WriteLine("Exception caught trying to overdraw the account");
        //     Console.WriteLine(e.ToString());
        //    }




        }
    }
}
