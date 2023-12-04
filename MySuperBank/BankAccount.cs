using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySuperBank
{
    public class BankAccount
    {
        public string Number { get; }
        public string Owner { get; set; }
        public decimal Balance { 
            
            get 
             { 
                decimal balance =0;
                foreach (var item in AllTransactions) 
                {
                    balance = balance + item.amount;
                }
                return balance;
            } 
        }

        private static int accountNumberSeed = 217779165;

        List<Transaction> AllTransactions = new List<Transaction>();

        public BankAccount(string name, decimal initialBalance)
        {
            name = Owner;
            MakeDeposit(initialBalance, DateTime.Now, "Initial Balance");
            Number = accountNumberSeed.ToString();
            accountNumberSeed++;
    }

        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive") ;
            }
           var deposit = new Transaction(amount, date, note);
            AllTransactions.Add(deposit);



        }
        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
            if (Balance - amount < 0)
            {
                throw new InvalidOperationException("Insufficient Funds");
            }
            var withdrawal = new Transaction(-amount, date, note);
            AllTransactions.Add(withdrawal);
        }
    }
}
