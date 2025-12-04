
using OCPViolationApp.Domain;

class Program
{


    static void Main() {

        var fd1 = new FixedDeposit(1001, "Alexander", 100000, 10,
            FestivalOptions.NormalDay);
        Console.WriteLine(fd1.SimpleInterest);
    }

}
