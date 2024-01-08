using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BatteSimulator.Modules.Warrior;

namespace BatteSimulator.Modules
{
    public interface IWizzard
    {
        string Name { get; set; }
        int Health { get; set; }
        int AttackPower { get; set; }
        int HealAmount { get; set; }

        void Attack(IEnemy enemy);


        void Heal(IWizzard wizzard);

    }

    public class Wizzard : IWizzard
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

        public void Heal(IWizzard wizzard)
        {
            wizzard.Health += 40;
        }
    }
}
