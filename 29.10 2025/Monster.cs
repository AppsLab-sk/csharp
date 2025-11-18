using _29._10_2025;
using System.ComponentModel;

namespace _29._10_2025
{
    public class Monster
    {
        private const int maxHP = 200;
        private const int minHP = 0;
        private int curentHP = maxHP;
        private int monsterDamage = 1;

        

        internal void TakeDamage(int damage)
        {

            curentHP -= damage;
        }

        public bool TakeDamage(Player opponent)
        {
            opponent.TakeDamage(monsterDamage);
            return true;
        }

        internal static void DealDamage(Player player)
        {
            throw new NotImplementedException();
        }
    }
}
