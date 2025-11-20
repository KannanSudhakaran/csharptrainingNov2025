
using RectangleAbstractionApp.Domain;
using System;

namespace RectangleAbstractionApp
{
     class Program
    {
        static void Main()
        {
            Rectangle smallRectangle;//null ,expects a rectangle object
            smallRectangle = new Rectangle();//created object
            PrintInfo(smallRectangle);

            smallRectangle.width = 1000;
            smallRectangle.height = 5;
            smallRectangle.color = "yellow";

            PrintInfo(smallRectangle);

            Rectangle temp = smallRectangle;
            temp.width = 100;

            Console.WriteLine($"temp width {temp.width}");
            Console.WriteLine($"smallRect width {smallRectangle.width}");
            Console.WriteLine($"temp hashcode {temp.GetHashCode()}");
            Console.WriteLine($"smallRect hashcode {smallRectangle.GetHashCode()}");


            Rectangle bigRectangle = new Rectangle();
            bigRectangle.width = 250;
            bigRectangle.height = 100;
            bigRectangle.color = "red";
            PrintInfo (bigRectangle);

        }

        static void PrintInfo(Rectangle rectangle) //expects an object
        {

            Console.WriteLine($" width is {rectangle.width}");
            Console.WriteLine($" height is {rectangle.height}");
            Console.WriteLine($" color is {rectangle.color}");
            Console.WriteLine($"Area is {rectangle.CalculateArea()}");
            Console.WriteLine($"hashCode {rectangle.GetHashCode()}");
        }
    }
}
