
using System;

class Program {

    static void Main(string[] userNames) {

        Console.WriteLine(userNames.Length);

        if (userNames.Length == 0)
        {
            Console.WriteLine("Please pass names");
            return;
        }

        foreach (string name in userNames) {
           
            Console.WriteLine($"Hello {name},how are you !!");
        }
            
    }

}