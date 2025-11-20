
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
            Console.WriteLine($" width is {smallRectangle.width}");
            Console.WriteLine($" height is {smallRectangle.height}");
            Console.WriteLine($" color is {smallRectangle.color}");
            Console.WriteLine(smallRectangle.CalculateArea());

            smallRectangle.width = 10;
            smallRectangle.height = 5;
            smallRectangle.color = "yellow";

            Console.WriteLine($" width is {smallRectangle.width}");
            Console.WriteLine($" height is {smallRectangle.height}");
            Console.WriteLine($" color is {smallRectangle.color}");
            Console.WriteLine(smallRectangle.CalculateArea());

        }
    }
}
