using ConsoleApp1;

namespace ConsoleApp1
{
    public class Monster
    {
        private const int maxHP = 200;
        private const int minHP = 0;

        private int currentHP = maxHP;
        private int Monsterdamage = 1;

        public Monster(string? monstername)
        {
        }

        public bool DealDamage(Player opponent)
        {
            opponent.Takedamage(Monsterdamage);
            return true;
        }

        internal void Takedamage(int damage)
        {
            currentHP -= damage;
        }
    }
}


