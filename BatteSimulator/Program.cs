using BatteSimulator.functions;
using BatteSimulator.Modules;

public class Program
{
    static void Main()
    {
        Console.Title = "ConsoleRPG by Martas_SK";
        Console.BufferWidth = 1000;
        var print =  new Print();
        var gm = new GameModes();
        print.Intro();
        gm.SetGameMode();
        //print.Soon();
    }
}//872 r