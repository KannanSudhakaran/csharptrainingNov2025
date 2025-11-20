using RectangleEncapsulationApp.Domain;
using System;

namespace RectangleEncapsulationApp
{
     class Program
    {
        static void Main()
        {
            // CaseStudy1();

            CaseStudy2();

        }

        private static void CaseStudy2()
        {
            Rectangle[] manyRectangles = new Rectangle[3];
            manyRectangles[0] = new Rectangle();
            manyRectangles[1] = new Rectangle();
            manyRectangles[2] = new Rectangle();

            manyRectangles[0].SetWidth(10);
            manyRectangles[0].SetHeight(20);
            manyRectangles[0].SetColor("red");

            manyRectangles[1].SetWidth(20);
            manyRectangles[1].SetHeight(30);
            manyRectangles[1].SetColor("blue");

            manyRectangles[2].SetWidth(50);
            manyRectangles[2].SetHeight(60);
            manyRectangles[2].SetColor("green");


            PrintInfo(manyRectangles);


        }

        private static void PrintInfo(Rectangle[] rectangles)
        {
            foreach (Rectangle rectangle in rectangles) {

                Console.WriteLine($"width is {rectangle.GetWidth()}");
                Console.WriteLine($"height is {rectangle.GetHeight()}");
                Console.WriteLine($"coor is {rectangle.GetColor()}");
                Console.WriteLine();
            }
            
        }

        private static void CaseStudy1()
        {
            Rectangle smallRectangle = new Rectangle();
            smallRectangle.SetWidth(100);
            Console.WriteLine($"width is {smallRectangle.GetWidth()}");

            smallRectangle.SetHeight(400);
            Console.WriteLine($"height is {smallRectangle.GetHeight()}");

            smallRectangle.SetColor("pink");
            Console.WriteLine(smallRectangle.GetColor());
        }
    }
}
