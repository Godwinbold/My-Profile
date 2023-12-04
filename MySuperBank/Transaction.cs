using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySuperBank
{
    internal class Transaction
    {
        public decimal amount {  get; }
        public DateTime date { get; }
        public string note { get; }


        public Transaction(decimal amount, DateTime date, string note) 
        { 
            amount = amount;
            date = date;
            note = note;
        }
    }

}
