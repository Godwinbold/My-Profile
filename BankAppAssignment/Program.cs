using Classes;



                Console.WriteLine("************************");
                Console.WriteLine("Welcome to Deca Bank");
                Console.WriteLine("***********************");

var account = new BankAccount("Godwin", 50000);
                 Console.WriteLine($"\nAccount Name: {account.Owner}" +
                 $" \nAccount Number: {account.Number} \nAccount Balance: " +
                 $"{account.Balance}.");


                  //account.MakeWithdrawal(2000, DateTime.Now, "Phone Purchase");
                 //Console.WriteLine(account.Balance);
                Console.WriteLine("_________________________________________________");


                Console.WriteLine("\nPlease, Select a Trasaction");
                Console.WriteLine("\n1. Deposit\n");
                Console.WriteLine("\n2. Withdrawal\n");
                Console.WriteLine("\n3. Transfer\n");
                Console.WriteLine("\n4. Exit\n");
                int Option = Convert.ToInt32(Console.ReadLine());



Console.WriteLine("Enter deposit amount");
                Console.WriteLine("amount:");
                int deposit = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nTransaction was successful!\n");

                Console.WriteLine("\nWould you like a receipt for this transaction?\n");
                Console.WriteLine("\n1. Yes\n");
                Console.WriteLine("\n2. No\n");
                int action = Convert.ToInt32(Console.ReadLine());





                        if (action == 1)
{
                 //Console.Clear();
                Console.WriteLine("\nTRANSACTION RECEIPT\n\n");
                Console.WriteLine("\nAmount Deposited: " );
                Console.WriteLine("\n\n\n Account balance: " + deposit);
                Console.WriteLine("\n\n");
                Console.WriteLine(DateTime.Now);
                Console.WriteLine("\n\nEnter a key to perform another transaction\n");


                 //account.MakeDeposit(340000, DateTime.Now, "Upkeep");
                Console.WriteLine(account.Balance);




                Console.ReadLine();
}
                //Console.WriteLine(account.GetAccountHistory());
