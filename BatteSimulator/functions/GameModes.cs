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
        public void SetGameMode()
        {
            var diff = new Difficulties();
            var ch = new Characters();
            //var _1v1 = new _1v1();

            Console.WriteLine("Choose your game mode: \n1. 1v1 (1 enemy) \n2. 1v1 (2 players) \n3. Comming soon... ");
            int action = int.Parse(Console.ReadLine());

            if (action == 1) 
            {
                //var gameMode = new _1v1();
                int gIndex = 1;
                double diffX = diff.SetDiff();
                ch.SetCH(diffX, gIndex);
            }

            if (action == 2)
            {
                int gIndex = 2;
                double diffX = diff.SetDiff();
                ch.SetCH(diffX, gIndex);
            }
        }

        public void ExeGameMode(int gIndex, ICharacter usedCh, IEnemy enemy) 
        {
            if (gIndex == 1)
            {
                var _1v1 = new _1v1();
                _1v1.Execute(usedCh, enemy);
            }

            if (gIndex == 2)
            {
                Console.WriteLine("Comming soon...");
            }
        }
    }
}
