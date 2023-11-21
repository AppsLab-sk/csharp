using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppsLab_020_OOP
{
    public class Warrior
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Attackpower { get; set; }

        public Warrior(string name, int health, int attackpower)
        {
            Name = name;
            Health = health;
            Attackpower = attackpower;
        }

        public void Attack(Mage enemy)
        {
            enemy.Health -= Attackpower;
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