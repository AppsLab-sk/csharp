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
            mojwizard.Attack = 200;
            warior mojwarior = new warior();
            mojwarior.name = "Minduri";
            mojwarior.health = 300;
            mojwarior.Attack = 80; 
        }
    }
}