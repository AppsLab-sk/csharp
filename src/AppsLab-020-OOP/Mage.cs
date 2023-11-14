using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppsLab_020_OOP
{
    public class Mage
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int AttackPower { get; set; }

        public void Attack(Warrior warrior)
        {
            Random r = new Random();
            int attackPower = r.Next(AttackPower);
            warrior.Health -= attackPower;
        }
        public void Defend()
        {
           
        }
        public void Heal()
        {
            
        }
    }
}
