

namespace SimpleDelegateApp
{

    delegate void DPrintMessage(string name);
    delegate void DMathOperation(int first, int second);

    internal class Program
    {
        static void Main(string[] args)
        {

            // CaseStudy1();

            // CaseStudy2();


            //PrintWizard(PrintGoodBye);

            DMathOperation manyOpertionPtr;
            manyOpertionPtr = Add;
            manyOpertionPtr += Sub;
            manyOpertionPtr += MultiPly;

            manyOpertionPtr(10, 5);
           
        }

        static void Add(int first, int second) {

            Console.WriteLine($" {first} + {second} = {first+second}");
        }
        static void Sub(int first, int second)
        {

            Console.WriteLine($" {first} - {second} = {first - second}");
        }
        static void MultiPly(int first, int second)
        {

            Console.WriteLine($" {first} * {second} = {first * second}");
        }

        static void PrintWizard(DPrintMessage fnCallback)//function callback
        {
            Console.WriteLine("inside print wizard");
            Console.WriteLine("doing some printing operation and will notify once done");

            fnCallback("Mr.PrintVizard");
        }

        private static void CaseStudy2()
        {
            DPrintMessage fnMultiPointer;

            fnMultiPointer = PrintHello;
            fnMultiPointer += PrintGoodBye; //+= equivalent list.Add()
            fnMultiPointer += PrintHello;

            fnMultiPointer("Daniel");
        }

        private static void CaseStudy1()
        {
            DPrintMessage fnPointer;// expects a function of same signature
            fnPointer = PrintHello;
            fnPointer("Daniel");
            fnPointer("Elena");
            fnPointer("Alexander");

        }

       private static void PrintGoodBye(string name) {

            Console.WriteLine($"Good bye says {name}");
        }

       private static void PrintHello(string name) {
            Console.WriteLine($"Hello says {name}");
         
        }

       static void Foo() {
            Console.WriteLine("inside foo");
        }
    }
}
