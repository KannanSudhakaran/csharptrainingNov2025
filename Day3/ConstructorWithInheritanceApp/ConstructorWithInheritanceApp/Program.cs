using ConstructorWithInheritanceApp.Domain.CaseStudy1;
using ConstructorWithInheritanceApp.Domain.CaseStudy2;

namespace ConstructorWithInheritanceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //new ChildOne();

            ChildTwo x = new ChildTwo();
            Console.WriteLine(x.Age);

            ChildTwo y = new ChildTwo(30);
            Console.WriteLine(y.Age);

        }
    }
}
