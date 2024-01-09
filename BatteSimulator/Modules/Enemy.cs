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

        void Attack(ICharacter warrior);

        void Heal();
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

        public void Attack(ICharacter usedCh)
        {
            usedCh.Health = Math.Max(0, usedCh.Health - Convert.ToInt32(AttackPower));
        }

        public void Heal()
        {
            Health += 20;
        }
    }
}
