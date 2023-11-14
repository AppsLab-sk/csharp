using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AppsLab_020_OOP
{
    internal class Wizard
    {
    public string name {  get; set; }
    public int health { get; set; }
    public int Attackpower { get; set; }

        public void Attack( Warior enemy)
        {
            Random random = new Random();
            int attackpower = random.Next(Attackpower);
            enemy.health -= attackpower;
        }
        public void Defend()
        {

        }
        public void Heal()
        {

        }

    }

}


