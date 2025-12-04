using OcpBankCoreLib.Domain;
using WorldBankApp.FestivalPolicies;

namespace WorldBankApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var fd1 = new FixedDeposit(2001, "Daniel", 100000, 10, new HalloweenFestivalRatePolicy());
            Console.WriteLine(fd1.SimpleInterest);
            
        }
    }
}
