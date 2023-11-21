using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppsLab_020_OOP
{
    internal class Warior
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Attackpower { get; set; }

        public Warior(string name, int health, int attackpower)
        {
            Name = name;
            Health = health;
            Attackpower = attackpower;
        }

        public bool StillAlive()
        {
            return Health > 0;
        }

        public override string? ToString()
        {
            return Name + "(" + Health + ")";
        }


        public void Attack(Wizard enemy)
        {
            Random random = new Random();
            int attackpower = random.Next(Attackpower);
            enemy.Health -= attackpower;
        }
    
        public void Defend()
        {

        }
        public void Heal()
        {

        }

     }

 }
