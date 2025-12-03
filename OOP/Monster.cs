
using System.Runtime.CompilerServices;

namespace OOP
{
    public class Monster
    {
        private const int maxHP = 200;
        private const int minHP = 0;
        private int currentHP = maxHP;
        private int damage = 1;
        public int damageHit = 15;

        public void TakeDamage(int damageHit)
        {
          currentHP -= damageHit;
        }
        public bool GiveDamage(Player opponent)
        {
            opponent.TakeDamage(damageHit);
            return true;

        }

    }
}

