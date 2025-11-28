using ManBoyInterfaceApp.Domain;

namespace ManBoyInterfaceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Man man = new Man();
            Boy boy = new Boy();

            AtTheParty(man);
            AtTheParty(boy);

           // AtTheMovies(man);
            AtTheMovies(boy);
        }

        static void AtTheParty(IMannerable mannerable) {

            Console.WriteLine("Party begins..");
            mannerable.Wish();
            mannerable.Depart();
        
        }

        static void AtTheMovies(IEmotionable emotionable)
        {
            Console.WriteLine("MOvie begins..");
            emotionable.Cry();
            emotionable.Laugh();
        }
    }
}
