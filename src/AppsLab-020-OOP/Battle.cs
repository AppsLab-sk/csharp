using System;

namespace AppsLab_020_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Orc orc = new Orc();
            Wizard wizard = new Wizard();

            Battle.SimulateBattle(orc, wizard);

            Console.ReadLine();
        }
    }

    public static class Battle
    {
        public static void SimulateBattle(Orc orc, Wizard wizard)
        {
            Console.WriteLine("Battle Start!");

            while (orc.StillAlive() && wizard.StillAlive())
            {
                orc.Attack(wizard);

                if (!wizard.StillAlive())
                {
                    Console.WriteLine(wizard.Name + " has been defeated. Orc wins!");
                    break;
                }

                wizard.Attack(orc);

                if (!orc.StillAlive())
                {
                    Console.WriteLine(orc.Name + " has been defeated. Wizard wins!");
                    break;
                }

                wizard.IncrementRoundCounter();
                wizard.GainMana();

                orc.ResetAction();
                wizard.ResetAction();

                Console.WriteLine("Current Status:");
                Console.WriteLine("Orc: " + orc);
                Console.WriteLine("Wizard: " + wizard);
                Console.WriteLine("----------------------");
            }

            Console.WriteLine("Battle End!");
        }
    }
}