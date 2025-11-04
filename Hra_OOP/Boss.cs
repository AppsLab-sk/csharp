
namespace Hra_OOP
{
    internal class Boss
    {
        private const int bossHealth = 800;
        private const int minHealth2 = 0;

        private int currentHp2 = bossHealth;
        private int bossDamage = 200;
        private object name2;
        Boss nepriatel = new Boss();


        public bool DealDamage(MojCharacter opponent)
        {
            opponent.TakeDamage(bossDamage);
            return true;
        }

        public void TakeDamage(int bossDamage)
        {
            currentHp2 -= bossDamage;
            if (currentHp2 < minHealth2) currentHp2 = minHealth2;
        }

        public int GetCurrentHp()
        {
            return currentHp2;
        }

        public override bool Equals(object? obj)
        {
            return obj is Boss boss &&
                   name2 == boss.name2;
        }
    }
}
