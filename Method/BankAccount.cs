

namespace MyBankApp
{
    public class BankAccount
    {
        public string Number { get; }
        public string Owner { get; set; }
        public Decimal Balance { get; set; }
        private static int AccountNumberSeed = 277791653;


        public BankAccount (string name, Decimal InitialBalance)
        {
            this.Owner = name;
            this.Balance = InitialBalance;
            this.Number = AccountNumberSeed.ToString();
            AccountNumberSeed++;
        }

        public void MakeDeposit(Decimal Amount, DateTime date, string note)
        {
           
        }
        
    }
}

