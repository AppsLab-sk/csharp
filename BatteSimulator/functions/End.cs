using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace BatteSimulator.functions
{
    public class End
    {
        public void EndGame()
        {
            var print = new Print();
            var gm = new GameModes();
            Console.Clear();
            print.Intro();
            //Console.SetCursorPosition(0, Console.CursorTop - 1);
            //print.Line();
            print.End();
            print.Line();
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            print.Input();
            int action = int.Parse(Console.ReadLine());

            if (action == 1)
            {
                Console.Clear();
                print.Intro();
                gm.SetGameMode();
                EndGame();
            }
            else
            {
                Environment.Exit(0);
            }
        }
    }
}
