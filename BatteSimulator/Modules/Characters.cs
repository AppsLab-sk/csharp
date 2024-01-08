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
            var ch1 = new Warrior("Bojovník", 200, 50, 2);

            var ch2 = new Wizzard("Čarodej", 100, 60, 2);
            
            var enemy = new Enemy("Enemy", 100 * diffX, 25 * diffX, 2 * diffX);

            var gm = new GameModes();

            Console.WriteLine($"Choose your character: \n1. {ch1.Name}, Health: {ch1.Health}, Damage: {ch1.AttackPower} \n2. {ch2.Name}, Health: {ch2.Health}, Damage: {ch2.AttackPower}");
            int action = int.Parse(Console.ReadLine());

            if (action == 1)
            {
                var usedCh = ch1;
                gm.ExeGameMode(gIndex, usedCh, enemy);
            }

            if(action == 2)
            {
                var usedCh = ch2;
                gm.ExeGameMode(gIndex, usedCh, enemy);
            }
        } 
    }
}
