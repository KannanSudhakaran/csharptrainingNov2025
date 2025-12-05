
namespace PreBuiltDelegateApp
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
            Predicate<int> predicatePtr = IsEvenNumber;
            Console.WriteLine(predicatePtr(3));
            Console.WriteLine(predicatePtr(30));
        }

        static bool IsEvenNumber(int no) {
            return (no % 2 == 0);
        }
        private static void CaseStudy2()
        {
            Action<string, int> actionPtr = PrintDetail;
            actionPtr("Elena", 5);
        }

        static void PrintDetail(string name, int iterations) {

            for (int iter = 1; iter <= iterations; iter++)
            {
                Console.WriteLine(name.ToUpper());
            }
        }

        private static void CaseStudy1()
        {

            Func<int, int, double> funcPtr=Multiply;

            double result =funcPtr(10, 5);
            Console.WriteLine(result);
        }

        static double Multiply(int first, int second) { 
        
            return first * second;
        }


    }
}
