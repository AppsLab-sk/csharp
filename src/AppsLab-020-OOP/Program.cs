using AppsLab_020_OOP;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Character
    {
        static void Main(string[] args)
        {

            var save = File.ReadAllLines("Save/Saves.txt");
            var warriorData = save[0].Split(';');
            var wizardData = save[1].Split(";");
            


            Mage mojmag = new Mage(wizardData[0], Int32.Parse(wizardData[1]) , Int32.Parse(wizardData[2]), Int32.Parse(wizardData[3]));
            Warrior mojwar = new Warrior(warriorData[0], Int32.Parse(warriorData[1]), Int32.Parse(warriorData[2]));

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

