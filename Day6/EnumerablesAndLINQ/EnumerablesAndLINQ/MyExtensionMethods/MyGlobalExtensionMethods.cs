
using PublisherLib.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace EnumerablesAndLINQ.MyExtensionMethods
{

 
   
    static class MyGlobalExtensionMethods
    {

        public static string SayHello(this string input) {

            return $"Hello says Daniel,Alexander,Elena to {input}";
        }

        public static void PrintInfo(this Account input) {

            Console.WriteLine("accno is "+input.Accno);
            Console.WriteLine("name is " + input.Name);
            Console.WriteLine("balance is "+input.Balance);
        }

    }
}
