// See https://aka.ms/new-console-template for more information
using AppsLab_020_OOP;

using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Wizard mojwizard = new Wizard();
            mojwizard.Name = "Zbojo";
            mojwizard.Health = 300;
            mojwizard.Attackpower = 190;
            Warior mojwarior = new Warior();
            mojwarior.Name = "Lojzo";
            mojwarior.Health = 500;
            mojwarior.Attackpower = 150;

            int round = 0;
            while (mojwizard.StillAlive() && mojwarior.StillAlive())
            {
                mojwizard.Attack(mojwarior);
                mojwarior.Attack(mojwizard);
                Console.WriteLine((round++) + " " + mojwarior + " vs " + mojwizard);
            }
       
            if (mojwarior.StillAlive())
            {
                Console.WriteLine("vyhral bojovnik warior");
            }
            if (mojwizard.StillAlive())
            {
                Console.WriteLine("vyhral bojovnik wizard");
            }
            if (!mojwizard.StillAlive() && !mojwarior.StillAlive())
            {
                Console.WriteLine("remizka");
            }



        }
    }
}
