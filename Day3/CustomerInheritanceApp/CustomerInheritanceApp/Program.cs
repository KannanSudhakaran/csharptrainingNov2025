using CustomerInheritanceApp.Domain;

namespace CustomerInheritanceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CaseStudy2();

            CaseStudy1();
        }

        private static void CaseStudy2()
        {
            Customer c1 = new Customer("101", "Daniel");
            Customer c2 = new Customer("101", "Daniel");
            Customer c3 = c1;

            Console.WriteLine(c1 == c2);//reference based equality
                                        // Console.WriteLine(c1==c3);

            Console.WriteLine(c1.Equals(c2));//value based equality
        }

        private static void CaseStudy1()
        {
            Customer c1 = new Customer("101", "Daniel");

            Console.WriteLine(c1);//polymorhism
            Console.WriteLine(c1.ToString());
            Console.WriteLine(c1.GetType());
        }
    }
}
