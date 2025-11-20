using RectangleEncapsulationApp.Domain;
using System;

namespace RectangleEncapsulationApp
{
     class Program
    {
        static void Main()
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
