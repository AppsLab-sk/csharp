using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppsLab_020_OOP
{
    internal class Mage
    {
        public string name { get; set; }
        public int Health { get; set; }
        public int AttackPower { get; set; }

        public void Attack(Warrior mojwar)
        {
            Random r = new Random();
            int attackPower = r.Next(AttackPower);
            mojwar.Health -= attackPower;

        }
        public void Defend()
        {

        }
        public void Heal()
        {

        }
    }
}
