using AppsLab_020_OOP.functions;
using System.Collections;
using System.ComponentModel.Design;
using System.Reflection;
using System.Threading;

public class Program
{
    static void Main()
    {
        var playerpc = new PlayerVsPc();
        var pcpc = new PcVsPc();
        var intro = new Intro();
        intro.Print();
        
        Console.WriteLine("Vyberte možnosť: \n1 Hráč proti počítaču \n2 Počítač proti počítaču");
        int action = int.Parse(Console.ReadLine());

        if (action == 1) 
        {
            playerpc.Execute();
        }
        if (action == 2) 
        {
            pcpc.Execute(); 
        }

    }
}