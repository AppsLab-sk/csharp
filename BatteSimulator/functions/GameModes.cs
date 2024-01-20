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
            var levels = new Levels();
            var diff = new Difficulties();
            var ch = new Characters();

            print.GmChoose();

            for (int i = 0; i < gm.Count; i++)
            {
                print.GmList(i, gm);
            }

            print.Input();

            int action = int.Parse(Console.ReadLine());
            
            int gIndex = action - 1;

            if (gm[gIndex].Name.StartsWith("Comming soon..."))
            {
                Console.Clear();
                print.Intro();
                
                print.Soon();
                
                print._1v1Continue();
                Console.ReadKey(true);
            }
            else 
            {
                levels.SetPlayer();
                double diffX = diff.SetDiff(); 
                ch.SetCH(diffX, gIndex); 
            }
        }

        public void ExeGameMode(int gIndex, ICharacter usedCh, IEnemy enemy)
        {
            IGameMode gmAtIndex = gm[gIndex];
            gmAtIndex.Execute(usedCh, enemy);
        }
    }
}
