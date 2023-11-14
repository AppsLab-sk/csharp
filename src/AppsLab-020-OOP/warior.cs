using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppsLab_020_OOP
{
    internal class Warior
    {
        public string name { get; set; }
        public int health { get; set; }
        public int AttackPower  { get; set; }

    public void Attack (Wizard enemy)
        {
           Random random = new Random();
            int attackpower = random.Next(AttackPower);
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
