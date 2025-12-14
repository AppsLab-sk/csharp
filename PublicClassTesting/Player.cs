
namespace PublicClassTesting
{
    public class Player
    {
        //const = ze je hodnota iba jedna
       private const int maxHP = 100;
       private const int minHP = 0;

        private int currentHP = maxHP;
        private string name;

        private int PlayerDamage = 20;
       private List<string> inventory = new List<string>();

        internal void TakeDamage(int MonsterDamage)
        {
            currentHP -= MonsterDamage;
        }
        public bool DealDamage(Monster opponent)
        {
            opponent.TakeDamage(PlayerDamage);
            return true;

        }

        internal void SetName(string? playerName)
        {
            name = playerName;
        }
    }

}

