using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace AppsLab_020_OOP
{
    public class Warrior
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int AttackPower { get; set; }
        public int Health { get; set; }

        public Warrior(string name, int age, int attackPower, int health)
        {
            Name = name;
            Age = age;
            AttackPower = attackPower;
            Health = health;
        }


        public void Attack(Enemy enemy)
        {
            enemy.Health -= AttackPower;
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


