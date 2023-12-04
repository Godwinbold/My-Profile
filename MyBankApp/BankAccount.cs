using System;
using System.Buffers;
using System.Collections.Generic;

//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace MyBankApp
{
    public class BankAccount
    {
        public string Number { get; }
        public string Owner { get; set; }
        public Decimal Balance { get; }

        public Account(string name, Decimal InitialBalance)
        {
            Owner = name;
            Balance = InitialBalance;

        }

        public void MakeDeposit(Decimal amount, DateTime date, string note)
        {

        }

        public void MakeDeposit(Decimal amount, DateTime date, string note)
        {

        }
    }
}
