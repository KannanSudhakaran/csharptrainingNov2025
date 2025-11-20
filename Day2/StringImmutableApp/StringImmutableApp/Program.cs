

using System;
using System.Text;

class Program {

    static void Main() {

        //  CaseStudy1();

        // CaseStudy2();

        CaseStudy3();
    }

    static void CaseStudy3() { 
    
        StringBuilder userNameBuilder = new StringBuilder();//mutable (modifiable)
        Console.WriteLine(userNameBuilder.GetHashCode());
        userNameBuilder.Append("Elena");
        Console.WriteLine(userNameBuilder.GetHashCode());
        userNameBuilder.Append("Daniel");
        Console.WriteLine(userNameBuilder.GetHashCode());
        userNameBuilder.Append("Alexander");

        string userName = userNameBuilder.ToString();
        Console.WriteLine(userName.GetHashCode());
        Console.WriteLine(userName);
    
    }
    static void CaseStudy2()
    {
        string userName = "Daniel";//Immutable 
        Console.WriteLine(userName.GetHashCode());
        userName += " Germany";
        Console.WriteLine(userName.GetHashCode());
        userName += " C# Developer";
        Console.WriteLine(userName.GetHashCode());

        Console.WriteLine(userName);

    }

    static void CaseStudy1() {

        string userName = "Alexander";
        Console.WriteLine(userName.GetHashCode());
        userName=userName.ToUpper();
        Console.WriteLine(userName.GetHashCode());
        Console.WriteLine(userName);
    
    }

}