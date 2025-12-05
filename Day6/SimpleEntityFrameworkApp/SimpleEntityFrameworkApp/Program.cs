using SimpleEntityFrameworkApp.Data;
using SimpleEntityFrameworkApp.Model;

namespace SimpleEntityFrameworkApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // CaseStudy1();

            MyCustomerDbContext db = new MyCustomerDbContext();

            foreach (var customer in db.Customers)
            {
                Console.WriteLine(customer);
            }
        }

        private static void CaseStudy1()
        {
            MyCustomerDbContext db = new MyCustomerDbContext();

            Customer c1 = new Customer();
            c1.Name = "Daniel";

            Customer c2 = new Customer();
            c2.Name = "Alex";

            Customer c3 = new Customer();
            c3.Name = "Kannan";

            db.Customers.Add(c1);
            db.Customers.Add(c2);
            db.Customers.Add(c3);

            db.SaveChanges();//flush changes to the db
            //serialize the object to row and columns
            Console.WriteLine("customers inserted");
        }
    }
}
