using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppsLab_020_OOP
{
    internal class Mage
    {
        public string name { get; set; }
        public int Health { get; set; }
        public int AttackPower { get; set; }

        public int Mana { get; set; } = 100;

        public Mage(string name, int health, int attackPower, int mana)
        {
            this.name = name;
            Health = health;
            AttackPower = attackPower;
            Mana = mana;
        }

        public void Attack(Warrior mojwar)
        {
            if (Mana > 0)
            {
                mojwar.Health -= AttackPower;
                Mana -= 20;
            }
            else
            {
                Mana += 25;
                Console.WriteLine(this + "Oddychuje");
            }

        }
        public bool StillAlive()
        {
            return Health > 0;
        }
        public override string? ToString()
        {
            return name + "(" + Health + ")";
        }
        

        }
        
    }

