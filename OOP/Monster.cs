
using System.Data.Common;

namespace OOP
{
    public class Monster
    {
        private string Name;
        private const int MaxHp = 200;
        private const int MinHp = 0;
        private int currentHP = MaxHp;
        private int MDamage = 10;

        internal void TakeDamage(int damage)
        {
            currentHP -= damage;
        }
        public bool DealDamage(player opponent)
        {
            opponent.TakeDamage(MDamage);
            return true;
        }

        internal void SetName(string? MonName)
        {
            Name = MonName;
        }
    }
}