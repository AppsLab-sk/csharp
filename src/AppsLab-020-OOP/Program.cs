﻿// See https://aka.ms/new-console-template for more information
using AppsLab_020_OOP;

using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var save = File.ReadAllLines("Save/Saves.txt");
            var wariorData = save[0].Split(',');
            var wizardData = save[0].Split(',');

          
        
            

            Wizard mojwizard = new Wizard(wizardData[0], Int32.Parse(wizardData[1]), Int32.Parse(wizardData[2]), Int32.Parse(wizardData[3]));
            var mojwarior = new Wizard(wizardData[0], Int32.Parse(wizardData[1]), Int32.Parse(wizardData[2]), Int32.Parse(wizardData[3]));


            int round = 0;
            while (mojwizard.StillAlive() && Warior.StillAlive())
            {
                mojwizard.Attack(Warior);
                Warior.Attack(mojwizard);
                Console.WriteLine((round++) + " " + Warior + " vs " + mojwizard);
            }
       
            if (Warior.StillAlive())
            {
                Console.WriteLine("vyhral warior " + Warior.Name);
            }
            if (mojwizard.StillAlive())
            {
                Console.WriteLine("vyhral wizard " + mojwizard.Name);
            }
            if (!mojwizard.StillAlive() && !Warior.StillAlive())
            {
                Console.WriteLine("remizka");
            }



        }
    }
}
