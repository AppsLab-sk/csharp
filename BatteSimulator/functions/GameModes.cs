using BatteSimulator.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatteSimulator.functions
{
    public class GameModes
    {
        List<IGameMode> gm = new List<IGameMode>()
        {
            new _1v1("1v1 (1 enemy)"),
            new CommingSoon("Comming soon..."),
            new CommingSoon("Comming soon..."),
            new CommingSoon("Comming soon..."),
        };
        public void SetGameMode()
        {
            var print = new Print();
            var diff = new Difficulties();
            var ch = new Characters();
            
            Console.WriteLine("Choose your game mode: "); //\n1. 1v1 (1 enemy) \n2. 1v1 (2 players) \n3. Comming soon... ");
            
            Console.SetCursorPosition(86, Console.CursorTop - 1);
            Console.Write("║");
            Console.SetCursorPosition(0, Console.CursorTop);

            for (int i = 0; i < gm.Count; i++)
            {
                Console.SetCursorPosition(86, Console.CursorTop);
                Console.WriteLine("║");
                Console.SetCursorPosition(0, Console.CursorTop);

                Console.Write($"{i + 1}. {gm[i].Name}");

                Console.SetCursorPosition(86, Console.CursorTop);
                Console.Write("║");
                Console.SetCursorPosition(0, Console.CursorTop);
            }
            
            Console.SetCursorPosition(0, Console.CursorTop + 2);
            print.EndLine();
            Console.SetCursorPosition(86, Console.CursorTop - 2);
            Console.Write("║");
            Console.SetCursorPosition(0, Console.CursorTop);

            int action = int.Parse(Console.ReadLine());
            
            int gIndex = action - 1;
            double diffX = diff.SetDiff();
            ch.SetCH(diffX, gIndex);
        }

        public void ExeGameMode(int gIndex, ICharacter usedCh, IEnemy enemy)
        {
            IGameMode gmAtIndex = gm[gIndex];
            gmAtIndex.Execute(usedCh, enemy);
        }
    }
}
