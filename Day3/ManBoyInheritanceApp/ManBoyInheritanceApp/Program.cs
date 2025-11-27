
using ManBoyInheritanceApp.Domain;

namespace ManBoyInheritanceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //CaseStudy1();

            //CaseStudy2();

            // CaseStudy3();


            CaseStudy4();
        }

        private static void CaseStudy4()
        {
            AtThePark(new Man());
            AtThePark(new Infant());
            AtThePark(new Boy());
            AtThePark(new Toddler());
        }

        static void AtThePark(Man x) //Polymorphic method
        
        {

            Console.WriteLine("At the park!!");
            x.Play();
        
        }

        private static void CaseStudy3()
        {
            Man x; //(ISA) x expects a Man or Boy

            x = new Boy();

            x.Play();//should call boy not man
            x.Read();


           
        }

        private static void CaseStudy2()
        {
            Boy y = new Boy();
            y.Eat();
            y.Play();
            y.Read();


        }

        private static void CaseStudy1()
        {

            Man x = new Man();
            x.Play();
            x.Read();
        }
    }
}
