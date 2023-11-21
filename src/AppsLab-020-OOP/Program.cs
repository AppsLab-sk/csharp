using AppsLab_020_OOP;
using System;
using static System.Net.Mime.MediaTypeNames;
using System.Threading;

 namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var save = File.ReadAllLines("Save/Saves.txt");
            var wariorData = save[0].Split(";");
            var wizardData = save[1].Split(";");

            Wizard mojwizard = new Wizard(wizardData[0], Int32.Parse(wizardData[1]), Int32.Parse(wizardData[2]), Int32.Parse(wizardData[3]));
            Warior mojwarior = new Warior(wariorData[0], Int32.Parse(wariorData[1]), Int32.Parse(wariorData[2]));




            int round = 0;
            while (mojwarior.StillAlive() && mojwizard.StillAlive()) 
            {
                mojwizard.Attack(mojwarior);
                mojwarior.Attack(mojwizard);
                Console.WriteLine((round++) + " " + mojwarior + "vs." + mojwizard);
            }
            if (mojwizard.StillAlive())
                Console.WriteLine(" Wizardwins" + mojwarior.name);
            if (mojwarior.StillAlive())
                Console.WriteLine("Warrior wins" + mojwizard.name );
            if (!mojwizard.StillAlive() && !mojwarior.StillAlive())
                Console.WriteLine("Remíza"); 
            
        }
    }
}  
            
            