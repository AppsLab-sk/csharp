using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatteSimulator.Modules
{
    public interface IEnemy
    {
        string Name { get; set; }
        double Health { get; set; }
        double AttackPower { get; set; }
        double HealAmount { get; set; }

        void Attack(IWarrior warrior);


        void Heal(IWizzard wizzard);

    }

    public class Enemy : IEnemy
    {
        public string Name { get; set; }
        public double Health { get; set; }
        public double AttackPower { get; set; }
        public double HealAmount { get; set; }

        public Enemy(string name, double health, double attackpower, double healamount)
        {
            Name = name;
            Health = health;
            AttackPower = attackpower;
            HealAmount = healamount;
        }

        public void Attack(IWarrior warrior)
        {
            //warrior.Health -= AttackPower;
            //warrior.Health = Math.Max(0, warrior.Health - AttackPower);
        }

        public void Heal(IWizzard wizzard)
        {
            //wizzard.Health += 40;
        }
    }
}
