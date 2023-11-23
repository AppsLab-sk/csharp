using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AppsLab_020_OOP
{
    internal class Wizard
    {
       

        public string name { get; set; }
        public int health { get; set; }
        public int Attackpower { get; set; }
        public int Mana { get; set; }

        public Wizard(string name, int health, int attackpower, int mana)
        {
            this.name = name;
            this.health = health;
            Attackpower = attackpower;
            Mana = mana;
        }

        

        public void Attack(Warior enemy)
        {
            Random r = new Random();
            int attackPower = r.Next(Attackpower);
            enemy.health -= attackPower;
            if (Mana > 0)
            {
                enemy.health -= Attackpower;
                Mana -= 20;
            }
            else
            {
                Mana += 25;
                Console.WriteLine(this + "Oddychuje");
            }

        }
        public void Attack(Wizard enemy)
        {
            Random r = new Random();
            int attackPower = r.Next(Attackpower);
            enemy.health -= attackPower;
            if (Mana > 0)
            {
                enemy.health -= Attackpower;
                Mana -= 20;
            }
            else
            {
                Mana += 25;
                Console.WriteLine(this + "Oddychuje");
            }

        }

        internal bool StillAlive()
        {
            return health > 0;
        }
        public override string? ToString()
        {
            return name + "(" + health + ")";
        }


    }
}









