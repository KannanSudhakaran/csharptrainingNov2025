using SimpleInterfaceApp.DataAccess;

namespace SimpleInterfaceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //polymorphism via interfaces

            DoDbOperations(new InvoiceDb());


        }

        static void DoDbOperations(ICrudable obj) {//polymorphic

            Console.WriteLine("Doing db operatins");
            obj.Create();
            obj.Read();
            obj.Update();
            obj.Delete();

            Console.WriteLine();
        
        }
    }
}
