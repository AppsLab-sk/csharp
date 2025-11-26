

using System.ComponentModel;

namespace ConsoleApp1
{
    public class Player
    {
        private const int maxHP = 100;
        private const int minHP = 0;

        private int currentHP = maxHP;
        private int damage = 25;
        List<string> inventory = new List<string>();
        private string Name;
        internal void SetName(string? playername)
        {
            Name = playername;
        }

        public bool DealDamage(Monster opponent)
        {
            opponent.Takedamage(damage);
            return true;
        }

        internal void Takedamage(int damage)
        {
            currentHP -= damage;
        }
    }
}
