using PublisherLib.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSubscriberClientApp.Notifications
{
    internal class EmailNotification : IAccountNotifiable
    {
        public void Notify(Account account)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Sending Email notification to");
            Console.WriteLine(account.Name);
            Console.WriteLine("Balance chaged to " + account.Balance);
            Console.ResetColor();
        }
    }
}
