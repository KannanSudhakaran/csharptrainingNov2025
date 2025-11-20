
using System;

class Program {

    static void Main() {



        PrintInfo("Hello");
        PrintInfo(10);
        PrintInfo(10.55f);
        PrintInfo(11.55);
        PrintInfo(12.55m);

    
    }

   static void PrintInfo(string input) {

        Console.WriteLine("Overload #1");
        Console.WriteLine(input);

    }

    static void PrintInfo(int input) {

        Console.WriteLine("Overload #2");
        Console.WriteLine(input);
        Console.WriteLine($"size of integer is {sizeof(int)}");
    }

    static void PrintInfo(float input)
    {

        Console.WriteLine("Overload #3");
        Console.WriteLine(input);
        Console.WriteLine($"size of float is {sizeof(float)}");
    }

    static void PrintInfo(double input)
    {

        Console.WriteLine("Overload #4");
        Console.WriteLine(input);
        Console.WriteLine($"size of double is {sizeof(double)}");
    }

    static void PrintInfo(decimal input)
    {

        Console.WriteLine("Overload #5");
        Console.WriteLine(input);
        Console.WriteLine($"size of decimal is {sizeof(decimal)}");
    }


}
