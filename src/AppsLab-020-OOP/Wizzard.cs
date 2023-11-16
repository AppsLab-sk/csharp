using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AppsLab_020_OOP
{

    public class Wizzard
    {
        public string Name { get; set; }
        public int Health { get; set; }

        public int AttackPower { get; set; }

        public int Mana { get; set; }


        public void Attack(Warrior enemy)
        {
            if (Mana > 0)
            {
                //enemy.Health -= AttackPower;
                enemy.Health = Math.Max(0, enemy.Health - AttackPower);
                Mana -= 20;
            }  
        }
        public void Heal(Wizzard wizzard) 
        {
            wizzard.Health += 20;
        }
    }

  
}