﻿using AppsLab_020_OOP;
using System;

 namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Wizard mojwizard = new Wizard();
            mojwizard.name = "Dakoty";
            mojwizard.healthh = 130;
            mojwizard.attackpower = 200;
            Warior mojwarior = new Warior();
          mojwarior.name = "Ferenci";
          mojwarior.health = 300;
            mojwarior.AttackPower = 80;
        }
    }
}  