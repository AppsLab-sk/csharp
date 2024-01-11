using BatteSimulator.functions;
using BatteSimulator.Modules;

public class Program
{
    public static void Main()
    {
        Console.Title = "ConsoleRPG by Martas_SK";
        Console.BufferWidth = 1000;
        var print =  new Print();
        var gm = new GameModes();
        var end = new End();
        print.Intro();
        gm.SetGameMode();

        end.EndGame();
    }
}//872 r