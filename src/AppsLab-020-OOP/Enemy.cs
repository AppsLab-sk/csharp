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
        public int Age { get; set; }
        public int AttackPower { get; set; }
        public int Health { get; set; }
        public int Mana { get; set; }

        public Enemy(string name, int age, int attackpower, int health, int mana)
        {
            Name = name;
            Age = age;
            AttackPower = attackpower;
            Health = health;
            Mana = mana; 
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
                Console.WriteLine(this + Name + "oddychuje.");
            }
        }

        public override string? ToString()
        {
            return Name + "(" + Health + ")";
        }
        public bool StillAlive()
        {
            return Health > 0;
        }
    }
}
