using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatteSimulator.Modules
{
    public interface ICharacter
    {
        string Name { get; set; }
        int Health { get; set; }
        int AttackPower { get; set; }
        int HealAmount { get; set; }

        void Attack(IEnemy enemy);

        void Heal();

    }
}
