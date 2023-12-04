using System;
using System.Collections.Generic;
using System.Transactions;

namespace Classes;

public class BankAccount
{
                    public string Number { get; }
                    public string Owner { get; set; }
                    #region BalanceComputation
                    public decimal Balance
                    {
                       get
                    {
                        decimal balance = 0;
                     foreach (var item in allTransactions)
                    {
                      balance += item.Amount;
                    }

                      return balance;
                    }
                    }
                       #endregion

    private static int s_accountNumberSeed = 217779165;
                        #region             Constructor
                        public BankAccount(string name, decimal initialBalance)
                        {
                         Number = s_accountNumberSeed.ToString();
                        s_accountNumberSeed++;

                          Owner = name;
     MakeDeposit(initialBalance, DateTime.Now, "Initial balance");
                        }
                        #endregion

                        #region                TransactionDeclaration
    private List<Transaction> allTransactions = new List<Transaction>();
                        #endregion

                        #region                 DepositAndWithdrawal
    public void MakeDeposit(decimal amount, DateTime date, string note)
                        {
                                if (amount <= 0)
                        {
                             throw new ArgumentOutOfRangeException(nameof(amount), "Deposits Only");
                        }
                            var deposit = new Transaction(amount, date, note);
                            allTransactions.Add(deposit);
                        }

    public void MakeWithdrawal(decimal amount, DateTime date, string note)
                        {
                                if (amount <= 0)
                        {
                                throw new ArgumentOutOfRangeException(nameof(amount), "Withdrawal Amount");
                        }
                                if (Balance - amount < 0)
                        {
                                throw new InvalidOperationException("Insufficient funds");
                        }
     var withdrawal = new Transaction(-amount, date, note);
                                allTransactions.Add(withdrawal);
                        }
                                #endregion

                                #region                     History
    public string GetAccountHistory()
                        {
                                var report = new System.Text.StringBuilder();

                                decimal balance = 0;
                                 report.AppendLine("Date\t\tAmount\tBalance\tNote");

                                 foreach (var item in allTransactions)
                         {
                                 balance += item.Amount;
      report.AppendLine($"{item.Date.ToShortDateString()}\t{item.Amount}\t{balance}\t{item.Notes}");
                         }

                                return report.ToString();
                         }
                                #endregion
}