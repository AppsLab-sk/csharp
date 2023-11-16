using AppsLab_020_OOP;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Character
    {
        static void Main(string[] args)
        {
            Mage mojmag = new Mage();
            mojmag.name = "Ferenci";
            mojmag.Health = 4000000;
            mojmag.AttackPower = 78;
            mojmag.Mana = 75;
            Warrior mojwar = new Warrior();
            mojwar.name = "Darius";
            mojwar.Health = 4000000;
            mojwar.AttackPower = 80;

            int round = 0;
            while (mojmag.StillAlive() && mojwar.StillAlive())
            {
                mojmag.Attack(mojwar);
                mojwar.Attack(mojmag);
                Console.WriteLine((round++) + " " + mojwar + "vs." + mojmag);
            }
            if (mojmag.StillAlive())
            Console.WriteLine("Mage wins");
            if(mojwar.StillAlive())
            Console.WriteLine("Warrior wins");
            if (!mojmag.StillAlive() && !mojwar.StillAlive())
            Console.WriteLine("Remíza");
        }
    }
}

