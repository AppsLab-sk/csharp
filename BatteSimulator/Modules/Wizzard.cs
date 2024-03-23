using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BatteSimulator.Modules.Warrior;

namespace BatteSimulator.Modules
{
    

    public class Wizzard : ICharacter
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int AttackPower { get; set; }
        public int HealAmount { get; set; }

        public Wizzard(string name, int health, int attackpower, int healamount)
        {
            Name = name;
            Health = health;
            AttackPower = attackpower;
            HealAmount = healamount;
        }

        public void Attack(IEnemy enemy)
        {
            //warrior.Health -= AttackPower;
            enemy.Health = Math.Max(0, enemy.Health - AttackPower);
        }

        public void Heal()
        {
            Health += 40;
        }
    }
}
