using AppsLab_020_OOP;
using System;

 namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
           Wizard mojwizard= new Wizard("Dakoty",400,250,100);
            
            Warior mojwarior = new Warior("Ferenci", 500, 150);
            

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
            
            