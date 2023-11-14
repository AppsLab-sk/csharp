using AppsLab_020_OOP;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            wizard mojwizard = new wizard();
            mojwizard.name = "Dakoty";
            mojwizard.health = 400;
            mojwizard.Attackpower = 100;
            mojwizard.Mana = 100;

            warrior mojwarior = new warrior();
            mojwarior.name = "Ferenci";
            mojwarior.health = 600;
            mojwarior.Attackpower = 100;
            
            int round = 0;
            while (mojwizard.StillAlive() && mojwarior.StillAlive())
            {
                mojwizard.Attack(mojwarior);
                mojwarior.Attack(mojwizard);
                Console.WriteLine((round++) + " " + mojwarior + " vs. " + mojwizard);
            }
            if (mojwizard.StillAlive())
                Console.WriteLine("Wizard wins!");
            else
                Console.WriteLine("warior wins!");
            if (mojwizard.StillAlive() && mojwarior.StillAlive())
            {
                Console.WriteLine("remiza :( ");
            }

        }
    }
}