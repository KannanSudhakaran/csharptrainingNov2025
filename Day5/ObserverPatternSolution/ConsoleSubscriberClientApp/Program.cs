using ConsoleSubscriberClientApp.Notifications;
using PublisherLib.Domain;

namespace ConsoleSubscriberClientApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create source object

            var acc1 = new Account("1001", "Elena");



            //change state of source

          
            acc1.RegisterObserver(new SmsNotification());
            acc1.RegisterObserver(new EmailNotification());
            //acc1.RegisterObserver(new SmsNotification());
            //acc1.RegisterObserver(new EmailNotification());

            acc1.Deposit(1000);
            acc1.Withdraw(500);




        }
    }
}
