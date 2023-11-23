using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppsLab_020_OOP
{
    internal class wizard
    {
        public string name { get; set; }
        public int health { get; set; }
        public int Attackpower { get; set; }
        public int Mana { get; set; } = 100;

        public wizard()
        {
            
        }
        public wizard(string name, int health, int attackPower, int mana)
        {
            this.name = name;
            health = health;
            attackPower = attackPower;
            Mana = mana;
        }
        public bool StillAlive()
        {
           return health > 0;
        }

        public override string ToString()
        {
            return name + "(" + health + ")";
        }
        public void Attack(warrior enemy)
        {
            if (Mana > 0)
            {
                enemy.health -= Attackpower;
                Mana -= 20;
            }
            else
            {
                Mana += 25;
                Console.WriteLine(this + "oddychuje");
            }
        }
        public void Attack(wizard enemy)
        {
            if (Mana > 0)
            {
                enemy.health -= Attackpower;
                Mana -= 20;
            }
            else
            {
                Mana += 25;
                Console.WriteLine(this + "oddychuje");
            }
        }
       


    }
       



    }



