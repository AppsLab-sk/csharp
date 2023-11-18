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

        public void Attack(Warior enemy, Wizard wizard, Wizard Wizard)
        {
            Random r = new Random();
            int attackPower = r.Next(Attackpower);
            wizard.health -= attackPower;
            if (Mana > 0)
            {
                wizard.health -= Attackpower;
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
    }
}









