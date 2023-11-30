using System;
using System.Collections.Generic;

namespace AppsLab_020_OOP
{
    public static class Battle
    {
        public static Random random = new Random();

        public static void SimulateBattle(List<ICharacter> orcs, List<ICharacter> wizards)
        {
            Console.WriteLine("Battle Start!");

            int round = 1;

            while (AtLeastOneStillAlive(orcs) && AtLeastOneStillAlive(wizards))
            {
                Console.WriteLine("Round " + round);

                foreach (var orc in orcs)
                {
                    ((Orc)orc).ResetAction();
                }

                foreach (var wizard in wizards)
                {
                    ((Wizard)wizard).ResetAction();
                }

                List<ICharacter> aliveOrcs = GetAliveCharacters(orcs);
                List<ICharacter> aliveWizards = GetAliveCharacters(wizards);

                if (aliveOrcs.Count == 0)
                {
                    Console.WriteLine("All orcs have been defeated. Wizards win!");
                    break;
                }

                if (aliveWizards.Count == 0)
                {
                    Console.WriteLine("All wizards have been defeated. Orcs win!");
                    break;
                }

                ICharacter randomOrc = aliveOrcs[random.Next(aliveOrcs.Count)];
                ICharacter randomWizard = aliveWizards[random.Next(aliveWizards.Count)];

                ((Orc)randomOrc).Attack((Wizard)randomWizard);
                if (!randomWizard.StillAlive())
                {
                    Console.WriteLine(((Wizard)randomWizard).Name + " has been defeated.");
                }

                ((Wizard)randomWizard).Attack((Orc)randomOrc);
                if (!randomOrc.StillAlive())
                {
                    Console.WriteLine(((Orc)randomOrc).Name + " has been defeated.");
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

            if (AtLeastOneStillAlive(orcs))
            {
                Console.WriteLine("Wizards have been defeated. Orcs win!");
            }
            else if (AtLeastOneStillAlive(wizards))
            {
                Console.WriteLine("Orcs have been defeated. Wizards win!");
            }
            else
            {
                Console.WriteLine("It's a draw! Both sides have been defeated.");
            }

            Console.WriteLine("Battle End!");
        }



        public static bool AtLeastOneStillAlive(List<ICharacter> creatures)
        {
            foreach (var creature in creatures)
            {
                if (creature.StillAlive())
                {
                    return true;
                }
            }
            return false;
        }

        public static List<ICharacter> GetAliveCharacters(List<ICharacter> creatures)
        {
            List<ICharacter> aliveCharacters = new List<ICharacter>();
            foreach (var creature in creatures)
            {
                if (creature.StillAlive())
                {
                    aliveCharacters.Add(creature);
                }
            }
            return aliveCharacters;
        }
    }
}