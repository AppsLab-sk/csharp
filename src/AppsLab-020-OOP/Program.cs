// See https://aka.ms/new-console-template for more information
using AppsLab_020_OOP;


using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var enemy = new Enemy();
            enemy.Age = 20;
            enemy.Name = "Hugo";
            enemy.Attack = 40;
            enemy.Health = 160;

            var warrior = new Warrior();
            warrior.Age = 5;
            warrior.Name = "Jožo";
            warrior.Attack = 30;
            warrior.Health = 180;
        }
    }   
}
