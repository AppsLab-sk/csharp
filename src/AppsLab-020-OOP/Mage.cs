using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace AppsLab_020_OOP
{
    public class Mage
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Attackpower { get; set; }
        public int Mana { get; set; } = 100;

        public Mage(string name, int health, int attackpower, int mana)
        {
            Name = name;
            Health = health;
            Attackpower = attackpower;
            Mana = mana;
        }
        public void Attack(Warrior enemy)
        {
            if (Mana > 0)
            {
                enemy.Health -= Attackpower;
                Mana -= 20;
            }
            else
            {
                Mana += 20;
                Console.WriteLine(this + "oddychuje");
            }
        }

        public bool StillALive()
        {
            return Health > 0;
        }


        public override string ToString()
        {
            return Name + " (" + Health + ")";
        }
    }
}
