using AppsLab_020_OOP;
using System;

 namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Wizard mojwizard = new Wizard();
            mojwizard.name = "Dakoty";
            mojwizard.health = 130;
            mojwizard.Attackpower = 200;
            Warior mojwarior = new Warior();
            mojwarior.name = "Ferenci";
            mojwarior.health = 300;
            mojwarior.AttackPower = 80;

            int round = 0;
            while (mojwarior.StillAlive() && mojwizard.StillAlive()) 
            {
                mojwarior.Attack(mojwizard);
                mojwarior.Attack(mojwizard);
                Console.WriteLine((round++) + " " + mojwarior + "vs." + mojwizard);
            }
            if (mojwizard.StillAlive())
                Console.WriteLine("Wizard wins");
            if (mojwarior.StillAlive())
                Console.WriteLine("Warrior wins");
            if (!mojwizard.StillAlive() && !mojwarior.StillAlive())
                Console.WriteLine("Remíza");
        }
    }
}  