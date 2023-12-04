//[10:39 AM] Saviour Armstrong

//using Microsoft.VisualBasic.FileIO;

//using System;

//using System.Collections.Generic;

//using System.Linq;

//using System.Text;

//using System.Threading.Tasks;

//using System.Transactions;

 

//namespace bankapp

//{

//    public class Withdrawal

//    {

//        double balance = 5000;

//        int receipt;

//        int transactionoption;



//        public void withdrawal()

//        {

//            Console.WriteLine("\nEnter withdrawal amount...\n");

//            double amount = Convert.ToDouble(Console.ReadLine());



//            if (balance < amount)

//            {

//                Console.WriteLine("\nYour account balance is not sufficient for this transaction\n\n");

//                Console.WriteLine("\nPress any button to perform another transaction\n");

//                Console.ReadKey();

//                Console.Clear();

//                Console.WriteLine("\n1. Withdraw\n");

//                Console.WriteLine("\n2. Deposit\n");

//                Console.WriteLine("\n3. Transfer\n");

//                Console.WriteLine("\n4. Exit\n");

//                Console.WriteLine("\nPlease select a transaction:\n");

//                transactionoption = Convert.ToInt32(Console.ReadLine());

//            }

//            else

//            {

//                Console.WriteLine("\nTransaction was successful!\n");

//                balance -= amount;



//                Console.WriteLine("\nWould you like a receipt for this transaction?\n");

//                Console.WriteLine("\n1. Yes\n");

//                Console.WriteLine("\n2. No\n");

//                receipt = Convert.ToInt32(Console.ReadLine());



//                if (receipt == 1)

//                {

//                    Console.Clear();

//                    Console.WriteLine("\nTRANSACTION RECEIPT\n\n");

//                    Console.WriteLine("\nTransaction amount: " + amount);

//                    Console.WriteLine("\n\n\n Account balance: " + balance);

//                    Console.WriteLine("\n\n");

//                    Console.WriteLine(DateTime.Now);

//                    Console.WriteLine("\n\nPress any button to perform another transaction\n");



//                    Console.ReadKey();

//                    Console.Clear();

//                    Console.WriteLine("\n1. Withdraw\n");

//                    Console.WriteLine("\n2. Deposit\n");

//                    Console.WriteLine("\n3. Transfer\n");

//                    Console.WriteLine("\n4. Exit\n");

//                    Console.WriteLine("\nPlease select a transaction:\n");

//                    transactionoption = Convert.ToInt32(Console.ReadLine());

//                }

//                else if (receipt == 2)

//                {



//                    Console.ReadKey();

//                    Console.Clear();

//                    Console.WriteLine("\n1. Withdraw\n");

//                    Console.WriteLine("\n2. Deposit\n");

//                    Console.WriteLine("\n3. Transfer\n");

//                    Console.WriteLine("\n4. Exit\n");

//                    Console.WriteLine("\nPlease select a transaction:\n");

//                    transactionoption = Convert.ToInt32(Console.ReadLine());

//                }

//            }

//        }

//    }

//}