using RectanglePropertiesApp.Domain;
using System;

namespace RectanglePropertiesApp
{
     class Program
    {
        static void Main()
        {

            Rectangle smallRectangle = new Rectangle();
            smallRectangle.Width = 10;
            smallRectangle.Height = 20;
            smallRectangle.Color = "green";
            smallRectangle.Border = BorderStyleOptions.Double;

           
            PrintInfo(smallRectangle);



        }

        private static void PrintInfo(Rectangle rectangle)
        {
            // Console.WriteLine(Console.ForegroundColor);
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine($"width {rectangle.Width}");
            Console.WriteLine($"height {rectangle.Height}");
            Console.WriteLine($"color {rectangle.Color}");
            Console.WriteLine($"border {rectangle.Border}");
            Console.ResetColor();
        }
    }
}
