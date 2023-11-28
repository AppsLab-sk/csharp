using System;
using System.Collections.Generic;

namespace AppsLab_020_OOP
{
    public static class Battle
    {
        private static Random random = new Random();

        public static void SimulateBattle(List<ICharacter> orcs, List<ICharacter> wizards)
        {
            Console.WriteLine("Battle Start!");

            int round = 1;

            while (AllStillAlive(orcs) && AllStillAlive(wizards))
            {
                Console.WriteLine("Round " + round);

                // Reset actions for the new round
                foreach (var orc in orcs)
                {
                    ((Orc)orc).ResetAction();
                }

                foreach (var wizard in wizards)
                {
                    ((Wizard)wizard).ResetAction();
                }

                ICharacter randomOrc = orcs[random.Next(orcs.Count)];
                ICharacter randomWizard = wizards[random.Next(wizards.Count)];

                ((Orc)randomOrc).Attack((Wizard)randomWizard);
                if (!randomWizard.StillAlive())
                {
                    Console.WriteLine(((Wizard)randomWizard).Name + " has been defeated. Orc wins!");
                    break;
                }

                ((Wizard)randomWizard).Attack((Orc)randomOrc);
                if (!randomOrc.StillAlive())
                {
                    Console.WriteLine(((Orc)randomOrc).Name + " has been defeated. Wizard wins!");
                    break;
                }

                round++;
                Console.WriteLine("Current Status:");
                foreach (var orc in orcs)
                {
                    Console.WriteLine("Orc: " + orc);
                }
                foreach (var wizard in wizards)
                {
                    Console.WriteLine("Wizard: " + wizard);
                }
                Console.WriteLine("----------------------");
            }

            Console.WriteLine("Battle End!");
        }

        private static bool AllStillAlive(List<ICharacter> creatures)
        {
            foreach (var creature in creatures)
            {
                if (!creature.StillAlive())
                {
                    return false;
                }
            }
            return true;
        }
    }
}