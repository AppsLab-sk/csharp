using BatteSimulator.functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatteSimulator.Modules
{
    public class Characters
    {
        public void SetCH(double diffX, int gIndex)
        {
            List<ICharacter> ch = new List<ICharacter>()
            {
                new Warrior("Bojovník", 200, 50, 2),
                new Wizzard("Čarodej", 100, 60, 2),
            };

            List<IEnemy> chE = new List<IEnemy>()
            {
                new Enemy("Enemy", 50 * diffX, 25 * diffX, 2 * diffX),
                //new Enemy("Enemy2", 100, 60, 2),
            };

            Random random = new Random();
            int randomIndex;
            randomIndex = random.Next(chE.Count);
            var enemy = chE[randomIndex];
            
            var print = new Print();
            var gm = new GameModes();

            print.ChChoose();
            
            for (int i = 0;  i < ch.Count; i++) 
            {
                print.ChList(i, ch);
            }

            print.Input();

            int action = int.Parse(Console.ReadLine());

            var usedCh = ch[action - 1];
            gm.ExeGameMode(gIndex, usedCh, enemy);            
        } 
    }
}
