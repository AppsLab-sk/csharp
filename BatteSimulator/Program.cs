using BatteSimulator.functions;
using BatteSimulator.Modules;

public class Program
{
    static void Main()
    {
        var print =  new Print();
        var diff = new Difficulties();

        print.Intro();

        double diffX = diff.SetDiff();

        Console.WriteLine(diffX);
    }
}