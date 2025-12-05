
using EnumerablesAndLINQ.MyExtensionMethods;
using PublisherLib.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EnumerablesAndLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // CaseStudy1();

            // CaseStudy2();

            CaseStudy3();
        }

        private static void CaseStudy3()
        {
            var accounts = new List<Account>();
            accounts.Add(new Account("1", "kannan", 1000));
            accounts.Add(new Account("2", "Alexander", 2000));
            accounts.Add(new Account("3", "Daniel", 3000));
            accounts.Add(new Account("4", "Elena", 4000));

            //write linq query to find 2 richest account holder

            var orderedAccountsQuery = accounts
                                 .OrderByDescending(a => a.Balance)
                                 .Take(2);
           
            foreach (var account in orderedAccountsQuery)
            {
                account.PrintInfo();
            }

            //write linq query to find names contain character e
            Console.WriteLine("displaying..names with character e found");
            accounts
                .Where(a => a.Name.Contains("e"))
                .ToList()
                .ForEach(a => a.PrintInfo());

        }

        private static void CaseStudy2()
        {
            string message = "kanna".SayHello();
            Console.WriteLine(message);

            var acc1 = new Account("101", "Elena");
            acc1.PrintInfo();
        }

        private static void CaseStudy1()
        {
            IEnumerable<string> userNames;
            userNames = new string[3] { "Daniel","Elena","Alexander" };

           var orderedNamesQuery=  userNames.OrderByDescending(n => n.Length);// deferred execution

           List<string> orderedNamesList=  orderedNamesQuery.ToList();//immediate execution
           orderedNamesList.ForEach(n => Console.WriteLine(n));


        }
    }
}
