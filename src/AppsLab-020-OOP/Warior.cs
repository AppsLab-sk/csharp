using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppsLab_020_OOP
{
    public class Warior
    {
        public string Name { get; set; }
        public int AttackPower { get; set; }
        public int Health { get; set; }

        public void Attack(Warior enemy)
               { Random r = new Random();
            int attackPower = r.Next(AttackPower);
            enemy.Health-=attackPower;



        }
        public bool StillAlive()
        {
            return Health > 0;
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
