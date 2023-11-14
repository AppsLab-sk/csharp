using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AppsLab_020_OOP
{
    public class Warrior
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int AttackPower { get; set; }

        public void Attack(Mage mage)
        {
            Random r = new Random();
            int attackPower = r.Next(AttackPower);
            mage.Health -= attackPower;
        }
        public void Defend()
        {

        }
        public void Heal()
        {

        }
    }
}
