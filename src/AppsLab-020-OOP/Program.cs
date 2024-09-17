using AppsLab_020_OOP.Fighters;
using System;

namespace AppsLab_020_OOP
{
    public class Program
    {
        static void Main(string[] args)
        {
            var save = File.ReadAllLines("Save/Saves.txt");

            string[] warriorData = save[0].Split(';');
            string[] wizardData = save[1].Split(';');


            var warrior = new Warrior(warriorData[0], Int32.Parse(warriorData[1]), Int32.Parse(warriorData[2]));
            var wizard = new Wizard(wizardData[0], Int32.Parse(wizardData[1]), Int32.Parse(wizardData[2]), Int32.Parse(wizardData[3]));


            int round = 0;
            while (wizard.StillAlive() && warrior.StillAlive())
            {
                wizard.Attack(warrior);
                warrior.Attack(wizard);
                Console.WriteLine((round++) + " " + warrior + " vs. " + wizard);
            }

            if (warrior.StillAlive())
            {
                Console.WriteLine("vyhral bojovnik s menom: " + warrior.Name);
            }
            if (wizard.StillAlive())
            {
                Console.WriteLine("vyhral bojovnik s menom: " + wizard.Name);
            }
            if (!wizard.StillAlive() && !warrior.StillAlive())
            {
                Console.WriteLine("remiza :( ");
            }
        }
    }
}
