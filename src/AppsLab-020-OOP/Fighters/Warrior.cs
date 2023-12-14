using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppsLab_020_OOP.Fighters
{
    internal class Warrior
    {
        public string Name { get; set; }
        public int AttackPower { get; set; }
        public int Health { get; set; }


        public Warrior(string name, int attackPower, int health)
        {
            Name = name;
            AttackPower = attackPower;
            Health = health;
        }

        public bool StillAlive()
        {
            return Health > 0;
        }

        public void Attack(Wizard enemy)
        {
            enemy.Health -= AttackPower;
        }

        public override string? ToString()
        {
            return Name + "(" + Health + ")";
        }

        public void Heal()
        {
            Health += 25;
        }
    }
}