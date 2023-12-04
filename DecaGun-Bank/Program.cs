
using DecaGun_Bank
using System;

namespace DecaGunBank
    {
    namespace DecaGod
    {
        class program
        {
            public void Main(string[] args)
            {
                var account = new MyBankAccount("Godwin", 10000);
                Console.WriteLine($"This {account.Number} for {account.Owner} with {account.Balance}");
            }
        }
    }
}



