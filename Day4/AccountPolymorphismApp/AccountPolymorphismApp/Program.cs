using AccountPolymorphismApp.Domain;
using System;

namespace AccountPolymorphismApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CaseStudy1();

            SavingsAccount sa = new SavingsAccount("1001", "Kannan", 2000);

            try
            {
                sa.Withdraw(1001);//panic , next line will not execute

                Console.WriteLine("withdraw completed sucessfully");
            }

           

            catch (AccountInsufficientFundsException ex) //ex expects ISA
            {

                Console.ForegroundColor = ConsoleColor.Red;
                //  Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.Message);
                Console.ResetColor();

            }

            catch (Exception ex) //ex expects ISA
            {

                Console.ForegroundColor = ConsoleColor.Yellow;
                //  Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.Message);
                Console.ResetColor();

            }


            Console.WriteLine("End of main");

        }

        private static void CaseStudy1()
        {
            SavingsAccount sa = new SavingsAccount("1001", "Daniel", 1000);
            CurrentAccount ca = new CurrentAccount("2001", "Alexander", 5000);

            PrintTxnDetails(sa);
            PrintTxnDetails(ca);

            sa.Withdraw(500);
            PrintTxnDetails(sa);
        }

        static void PrintTxnDetails(Account account) {

            Console.WriteLine("printing txn details");
            Console.WriteLine($"for {account.Name} , accno {account.AccountNo} ");
            Console.WriteLine($"Updated balance is {account.Balance}");
            Console.WriteLine();
        
        }
    }
}
