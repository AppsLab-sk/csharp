
namespace OOP
{
    public class Player
    {
        private string PlayerName;
        private const int maxHP = 100;
        private const int minHP = 0;
        private int currentHP =maxHP;
        private  int damage = 20;
        List<string> inventory = new List<string>();

         public bool DealDamage(Monster opponent)
        {
            opponent.TakeDamage(damage); 
            return true;

        }
       public void TakeDamage(int damage)
        {
            currentHP -= damage;
        }

        internal void setName(string? playerName)
        {
            PlayerName = playerName;
        }
    }
}
