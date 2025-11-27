using PlayerCounterApp.Domain;

namespace PlayerCounterApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Player p1 = new Player("Elena");
             Console.WriteLine(p1.Counter);//Counter(p1)
            Console.WriteLine(Player.HeadCounter);

            Player p2 = new Player("Daniel");
            //Console.WriteLine(p1.Counter);
            Console.WriteLine(Player.HeadCounter);


            Player p3 = new Player("Alexander");
            //Console.WriteLine(p1.Counter);
            Console.WriteLine(Player.HeadCounter);


        }
    }
}
