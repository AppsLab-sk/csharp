using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AppsLab_020_OOP
{
    public class Mage
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int AttackPower { get; set; }
        public int Mana { get; set; }
        public int HealthPots { get; set; }

        public Mage(string name, int health, int attackPower, int mana, int healthPots)
        {
            Name = name;
            Health = health;
            AttackPower = attackPower;
            Mana = mana;
            HealthPots = healthPots;
        }

        public void Attack(Warrior warrior)
        {

            if (Mana > 20)
            {
                warrior.Health -= AttackPower;
                Mana -= 20;
            }
            else
            {
                Mana += 25;
                Console.WriteLine(this + Name + " is resting.");
            }

        }
        public void Heal()
        {
            if (Health <= 50 && HealthPots >=1)
            {
                Health += 50;
                HealthPots -= 1;
                Console.WriteLine(this + Name + " is using a health potion.");
            }
            else if (HealthPots == 0)
            {
                Health += 0;
            }
        }
        public bool StillAlive()
        {
            return Health > 0;
        }
        public override string ToString()
        {
            return Name + " (" + Health + ")";
        }
    }

}
