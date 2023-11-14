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
            mojwizard.Health = 500;
            mojwizard.Attackpower = 150;


        }
    }
}
