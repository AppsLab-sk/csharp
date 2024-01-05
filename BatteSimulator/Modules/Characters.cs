using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatteSimulator.Modules
{
    public class Characters
    {
        public interface IWarrior
        {
            string Name { get; set; }
            int Health { get; set; }
            int AttackPower { get; set; }
            int HealAmount { get; set; }

            void Attack(IWizzard wizzard);

            void Heal(IWarrior warrior);

        }

        public class Warrior : IWarrior
        {
            public string Name { get; set; }
            public int Health { get; set; }
            public int AttackPower { get; set; }
            public int HealAmount { get; set; }

            public Warrior(string name, int health, int attackpower, int healamount)
            {
                Name = name;
                Health = health;
                AttackPower = attackpower;
                HealAmount = healamount;
            }

            public void Attack(IWizzard wizzard)
            {
                //wizzard.Health -= AttackPower;
                wizzard.Health = Math.Max(0, wizzard.Health - AttackPower);
            }

            public void Heal(IWarrior warrior)
            {
                warrior.Health += 40;
            }
        }
    }
}
