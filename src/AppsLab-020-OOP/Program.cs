using AppsLab_020_OOP;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Character
    {
        static void Main(string[] args)
        {
            Mage mojmag = new Mage();
            mojmag.name = "Ferenci";
            mojmag.Health = 275;
            mojmag.AttackPower = 78;
            Warrior mojwar = new Warrior();
            mojwar.name = "Darius";
            mojmag.Health = 325;
            mojmag.AttackPower = 65;           
        }
    }
}
