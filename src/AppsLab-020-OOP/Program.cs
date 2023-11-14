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
            mojwizard.name = "Zbojo";
            mojwizard.health = 300;
            mojwizard.Attack = 190;
            Warior mojwarior = new Warior();
            mojwarior.name = "Lojzo";
            mojwizard.health = 500;
            mojwizard.Attack = 150;


        }
    }
}
