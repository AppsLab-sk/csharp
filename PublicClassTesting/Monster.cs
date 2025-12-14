namespace PublicClassTesting
{
    public class Monster
    {
        private const int maxHP = 200;
        private const int minHP = 0;

        private int currentHP = maxHP;


        private int MonsterDamage = 1;

        internal void TakeDamage(int damage)
        {
            currentHP -= damage;
        }
        public bool DealDamage(Player player)
        {
            player.TakeDamage(MonsterDamage);
            return true;

        }
    }
}