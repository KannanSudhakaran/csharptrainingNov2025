using AccountPolymorphismApp.Domain;
using System;

namespace AccountPolymorphismApp
{
    internal class Program
    {
        static void Main(string[] args)
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
