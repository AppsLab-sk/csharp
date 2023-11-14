using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppsLab_020_OOP
{
    internal class warrior
    {
        public string name { get; set; }
        public int health { get; set; }
        public int Attackpower { get; set; }


        public void Attack(wizard enemy)
        {
            Random random = new Random();
            int attackpower = random.Next(Attackpower);
            enemy.health-=attackpower;
        }
        public void Defend()
        {

        }
        public void Heal()
        {

        }

    }

}