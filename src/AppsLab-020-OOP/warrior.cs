using AppsLab_020_OOP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace AppsLab_020_OOP
{
    public class Warrior
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int AttackPower { get; set; }

        public Warrior(string name, int health, int attackPower)
        {
            Name = name;
            Health = health;
            AttackPower = attackPower;
        }

        public bool StillAlive()
        {
            return Health > 0;
        }

        public override string? ToString()
        {
            return Name + "(" + Health + ")";
        }

        public void Attack(Wizard wizard) 
        {
            wizard.Health -= AttackPower;
        }








    }
}






