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
        public int Bandages { get; set; }

        public void Attack(Mage mage)
        {
            mage.Health -= AttackPower;
        }
        public void Heal(Warrior warrior)
        {
            if (Health <= 50)
            {
                Health += 20;
                Bandages -= 1;
            }
            else if (Bandages <= 0)
            {
                Health += 0;
            }
        }
        public bool StillAlive()
        {
            return Health > 0;
        }
        public override string ToString()
        {
            return Name + "(" + Health + ")";
        }
        public void Ultimate(Mage mage)
        {
            if (Health <= 40)
            {
                Console.WriteLine(Name + " is unleashing ultimate!");
                mage.Health -= 3 * AttackPower;
            }
            else
            {
                mage.Health -= AttackPower;
            }
        }
    }
}
