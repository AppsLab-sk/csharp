using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace AppsLab_020_OOP
using System;

namespace AppsLab_020_OOP
{
    public class Battle
    {
        public static void SimulateBattle(Wizard wizard, Ork ork, int maxRounds)
        {
            Console.WriteLine($"Battle begins between {wizard.Name} and {ork.Name}");

            for (int round = 1; round <= maxRounds; round++)
            {
                Console.WriteLine($"Round {round}");

                // Wizard attacks Ork
                wizard.Attack(ork);
                Console.WriteLine($"{wizard.Name} attacks {ork.Name}. {ork.Name}'s health: {ork.Health}");

                // Check if Ork is still alive
                if (!ork.StillAlive())
                {
                    Console.WriteLine($"{ork.Name} has been defeated!");
                    break;
                }

                // Ork attacks Wizard
                ork.Attack(wizard);
                Console.WriteLine($"{ork.Name} attacks {wizard.Name}. {wizard.Name}'s health: {wizard.Health}");

                // Check if Wizard is still alive
                if (!wizard.StillAlive())
                {
                    Console.WriteLine($"{wizard.Name} has been defeated!");
                    break;
                }
            }

            Console.WriteLine("Battle ended.");
        }
    }
}

