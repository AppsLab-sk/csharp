using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppsLab_020_OOP
{
    internal class Wizard
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Attackpower { get; set; }
        public int Mana { get; set; }

        public bool StillAlive()
        {
            return Health > 0;
        }

        public override string? ToString()
        {
            return Name + "(" + Health + ")";
        }

        public void Attack(Warior enemy)
        {
          if (Mana > 0)
            {
                enemy.Health -= Attackpower;
                Mana -= 20;
            }  
             else
            {
                Mana += 25;
                Console.WriteLine(this + "oddychuje");
            }
        }   

        public void Defend()
        {

        }
        public void Heal()
        {

        }

    }
}

