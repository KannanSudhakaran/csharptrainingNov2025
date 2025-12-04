using CityBankApp.QuarterPolicies;
using OcpBankCoreLib.Domain;

namespace CityBankApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var fd = new FixedDeposit(201, "Elena", 100000, 10, new Q1Policy());
            Console.WriteLine(fd.SimpleInterest);
        }
    }
}
