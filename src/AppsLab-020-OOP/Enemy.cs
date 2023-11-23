
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppsLab_020_OOP
{
    public class Enemy
    {
        public string Name { get; set; }
        public int AttackPower { get; set; }
        public int Health { get; set; }
        public int Mana { get; set; } = 100;

        public Enemy(string name, int attackPower, int health, int mana)
        {
            Name = name;
            AttackPower = attackPower;
            Health = health;
            Mana = mana;
        }

        public void Attack(Warior enemy)
        {
            if (Mana > 0)
            {
                enemy.Health -= AttackPower;
            }
            else
            {
                Mana += 25;
                Console.WriteLine(this + "oddychuje");

            }
        }
        public void Attack(Enemy enemy)
        {
            if (Mana > 0)
            {
                enemy.Health -= AttackPower;
            }
            else
            {
                Mana += 25;
                Console.WriteLine(this + "oddychuje");

            }
        }
        public bool StillAlive()
        { return Health > 0; 
        }
        public override string ToString()
        {
            return Name + "(" + Health + ")";
        }
        public void Defend()
        {

        }
        public void Heal()
        {

        }
    }
}
