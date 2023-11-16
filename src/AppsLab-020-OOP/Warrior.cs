using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AppsLab_020_OOP
{
    internal class Warrior
    {
        public string name { get; set; }
        public int Health { get; set; }
         public int AttackPower { get; set; }

        public void Attack(Mage mojmag)
        {
            Random r = new Random();
            int attackPower = r.Next(AttackPower);
            mojmag.Health -= attackPower;
        }
            public bool StillAlive()
            {
                return Health > 0;
            }
        public override string? ToString()
        {
            return name + "(" + Health + ")";
        }

    }
}

