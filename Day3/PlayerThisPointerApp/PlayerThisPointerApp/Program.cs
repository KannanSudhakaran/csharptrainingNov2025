using PlayerThisPointerApp.Domain;
using System;

namespace PlayerThisPointerApp
{
     class Program
    {
        static void Main()
        {
            Player alexander = new Player("Alexander",25);
            PrintDetails(alexander);


            Player daniel = new Player("Daniel");
            PrintDetails(daniel);

           Player elder = alexander.WhoIsElder(daniel);//WhoIsElder(alexander,deniel);
           PrintDetails(elder);
        }

        private static void PrintDetails(Player player)
        {
            Console.WriteLine($"name is {player.Name}, age is {player.Age}");
            Console.WriteLine($"hashcode {player.GetHashCode()}");
        }
    }
}
