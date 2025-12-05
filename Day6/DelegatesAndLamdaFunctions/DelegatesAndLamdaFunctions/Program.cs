
namespace DelegatesAndLamdaFunctions
{
    internal class Program
    {
        static void Main(string[] args)
        {


            // CaseStudy1();
            //CaseStudy2();

            CaseStudy3();
        }

        private static void CaseStudy3()
        {
            Predicate<int> checkEven = (no) => no % 2 == 0;

            Console.WriteLine(checkEven(50));
            Console.WriteLine(checkEven(55));

        }

        private static void CaseStudy2()
        {
            Action<string, int> printDetails = (name, iterations) =>
            {
                for (int i = 1; i < iterations; i++)
                {
                    Console.WriteLine(name.ToUpper());

                }
            };

            printDetails("Daniel", 10);
        }

        private static void CaseStudy1()
        {
            Func<int, int, double> mulitply = (a,b) => {
                return a*b;
            };

            double result = mulitply(10, 5);
            Console.WriteLine(result);

        }
    }
}
