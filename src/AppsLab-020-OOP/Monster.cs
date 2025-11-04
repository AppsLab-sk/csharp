

namespace AppsLab_020_OOP
{
    public class Monster
    {
        private const int maxHp = 200;
        private const int minHp = 0;

        private int currentHp = maxHp;
        private int MonsterDamage = 1;

        internal void TakeDamage(int MonsterDamage)
        {
            currentHp -= MonsterDamage;
        }
        public bool DealDamage(Player opponent)
        {
            opponent.TakeDamage(MonsterDamage);
            return true;
        }
    }
}