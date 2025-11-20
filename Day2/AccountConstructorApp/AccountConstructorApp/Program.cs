using AccountConstructorApp.Domain;
using System;

namespace AccountConstructorApp
{
     class Program
    {
        static void Main()
        {
            Account accountofAlex = new Account("1001", "Alexander", 1000);
            Account accountofDaniel = new Account("2001", "Daniel");

            PrintInfo(accountofAlex);
            accountofAlex.Deposit(500);//Deposit(accountofalex,500);
            PrintInfo(accountofAlex);

            PrintInfo(accountofDaniel);
            accountofDaniel.Withdraw(100);
            PrintInfo(accountofDaniel);

           // accountofAlex.Name = "ALeX";

        }

        static void PrintInfo(Account account)
        {

            Console.WriteLine($"Name is {account.Name}");
            Console.WriteLine($"Accno is {account.Accno}");
            Console.WriteLine($"Balance is {account.Balance}");
            Console.WriteLine();
        }
    }
}
