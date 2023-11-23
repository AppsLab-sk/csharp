using AppsLab_020_OOP;
using System;
using static System.Net.Mime.MediaTypeNames;
using System.Threading;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Character
    {
        static void Main(string[] args)
        {

            var save = File.ReadAllLines("svae/saves.txt");
            var warriorData = save[0].Split(';');
            var wizardData = save[1].Split(";");



            var mojmag = new wizard(wizardData[0], Int32.Parse(wizardData[1]), Int32.Parse(wizardData[2]), Int32.Parse(wizardData[3]));
            var mojwar = new wizard(wizardData[0], Int32.Parse(wizardData[1]), Int32.Parse(wizardData[2]), Int32.Parse(wizardData[3]));

            int round = 0;
            while (mojmag.StillAlive() && mojmag.StillAlive())
            {
                mojmag.Attack(mojmag);
                mojwar.Attack(mojmag);
                Console.WriteLine((round++) + " " + mojmag + "vs." + mojmag);
            }
            if (mojmag.StillAlive())
                Console.WriteLine("Mage wins");
            if (mojmag.StillAlive())
                Console.WriteLine("Warrior wins");
            if (!mojmag.StillAlive() && !mojmag.StillAlive())
                Console.WriteLine("Remíza");
        }
    }
}