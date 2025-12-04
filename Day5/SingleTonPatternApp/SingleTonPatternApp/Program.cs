using SingleTonPatternApp.Services;

namespace SingleTonPatternApp
{
    internal class Program
    {
        static void Main(string[] args)
        {



            DataService service1 = DataService.GetInstance();
            DataService service2 = DataService.GetInstance();


            Console.WriteLine(service1.GetHashCode());
            Console.WriteLine(service2.GetHashCode());

            Console.WriteLine(service1.GetData());
            Console.WriteLine(service2.GetData());
        }
    }
}
