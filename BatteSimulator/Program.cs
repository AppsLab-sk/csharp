using BatteSimulator.functions;
using BatteSimulator.Modules;

public class Program
{
    static void Main()
    {
        var print =  new Print();
        var gm = new GameModes();
        print.Intro();
        //gm.SetGameMode();
        print.Soon();
    }
}