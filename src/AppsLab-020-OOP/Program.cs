using AppsLab_020_OOP;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var mage = new Character();
            mage.Name = "Enkudu"; 
            mage.Health = 100;
            mage.Attack = 15;

            var warrior = new Character();
            warrior.Name = "Arkback";
            warrior.Health = 125;
            warrior.Attack = 10;

    }
}