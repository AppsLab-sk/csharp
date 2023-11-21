using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using System;

namespace AppsLab_020_OOP
{
    public class Ork
    {
        public string Name { get; set; }
        public int Health { get; set; } = 80;
        public int AttackPower { get; set; } = 30;

        public Ork(string name, int health, int attackPower)
        {
            Name = name;
            Health = health;
            AttackPower = attackPower;
        }

        public void Attack(Wizard wizard)
        {
            if (wizard.StillAlive())
            {
                Health -= AttackPower;
                wizard.Health -= 30;
            }
            else
            {
                wizard.Health += 25;
                Console.WriteLine($"Ork is resting");
            }
        }

        public void Defend()
        {
            // Implement defense logic here if needed
            Console.WriteLine($"Ork is defending!");
        }

        public void Heal()
        {
            // Implement healing logic here if needed
            Console.WriteLine($"Ork is healing!");
        }

        public bool StillAlive()
        {
            return Health > 0;
        }

        public override string ToString()
        {
            return $"Ork({Health})";
        }
    }
}
