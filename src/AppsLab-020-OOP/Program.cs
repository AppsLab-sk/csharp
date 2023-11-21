// See https://aka.ms/new-console-template for more information
using AppsLab_020_OOP;

using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Wizard mojwizard = new Wizard("janko", 1000 , 100 , 100);

            var Warior = new Warior("pišta", 500 , 100);
           

            int round = 0;
            while (mojwizard.StillAlive() && Warior.StillAlive())
            {
                mojwizard.Attack(Warior);
                Warior.Attack(mojwizard);
                Console.WriteLine((round++) + " " + Warior + " vs " + mojwizard);
            }
       
            if (Warior.StillAlive())
            {
                Console.WriteLine("vyhral bojovnik warior");
            }
            if (mojwizard.StillAlive())
            {
                Console.WriteLine("vyhral bojovnik wizard");
            }
            if (!mojwizard.StillAlive() && !Warior.StillAlive())
            {
                Console.WriteLine("remizka");
            }



        }
    }
}
