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

            Console.SetCursorPosition(86, Console.CursorTop);
            Console.WriteLine("║");
            Console.SetCursorPosition(0, Console.CursorTop - 1);

            Console.Write($"Choose your character: ");//\n1. {ch1.Name}, Health: {ch1.Health}, Damage: {ch1.AttackPower} \n2. {ch2.Name}, Health: {ch2.Health}, Damage: {ch2.AttackPower}");
            
            for (int i = 0;  i < ch.Count; i++) 
            {
                Console.SetCursorPosition(86, Console.CursorTop);
                Console.WriteLine("║");
                Console.SetCursorPosition(0, Console.CursorTop);

                Console.Write($"{i+1}. {ch[i].Name}, Health: {ch[i].Health}, Damage: {ch[i].AttackPower}");

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

            var usedCh = ch[action - 1];
            gm.ExeGameMode(gIndex, usedCh, enemy);            
        } 
    }
}
