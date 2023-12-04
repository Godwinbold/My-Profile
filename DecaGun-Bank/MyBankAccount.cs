using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecaGun_Bank
{
    public class MyBankAccount
    {
        public string Number {  get; }
        public string Owner { get; set; }
        public Decimal Balance {  get; } 

        public MyBankAccount(string name, decimal initialBalance)
        {
            this.Owner = name;
            this.Balance = initialBalance;
        }


        public void MakeDeposit(Decimal amount, DateTime date, string note)
        {
        }
        public void MakeWithdrawal(Decimal amount, DateTime date, string note)
        {

        }


    }
}
