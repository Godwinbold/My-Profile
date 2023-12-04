using System;
namespace MySuperBank
{
    class program
    {
        public void Main(string[] args)
        {
            var account = new BankAccount("Godwin", 100000);

            Console.WriteLine($"The {account.Number} for {account.Owner} with {account.Balance}");
            account.MakeWithdrawal(300, DateTime.Now, "Phone");
            Console.WriteLine(account.Balance);
            //Console.WriteLine(account.GetAccountHistory());

        }
    }
}