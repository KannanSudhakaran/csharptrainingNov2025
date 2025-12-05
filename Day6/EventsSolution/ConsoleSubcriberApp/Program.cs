using PublisherLib.Domain;

namespace ConsoleSubcriberApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Account acc1 = new Account("101", "Alexander");

           
            acc1.OnBalanceChanged += SendEmailHandler;
            acc1.OnBalanceChanged += SendSmsHandler;
            acc1.OnBalanceChanged += SendSmsHandler;
            acc1.OnBalanceChanged -= SendSmsHandler;

            acc1.Deposit(1000);

        }

        static void SendEmailHandler(Account acc) {

            Console.WriteLine("sending email");
            Console.WriteLine("new balance is :"+acc.Balance);
        
        
        }

        static void SendSmsHandler(Account account) {

            Console.WriteLine("sending sms");
            Console.WriteLine("new balance is :" + account.Balance);

        }


    }
}
