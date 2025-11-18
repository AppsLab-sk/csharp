
namespace _29._10_2025
{
    public class Player
    {
        private string Name;
      private const int maxHP = 100;
       private const int minHP = 0;
        private int curentHP = maxHP;
       private int playerDamage = 20;
      private  List<string> invetory = new List<string>();
       
       
       public bool DealDamage(Monster opponent)
        {
            opponent.TakeDamage(playerDamage);
            return true;

        }
        internal void SetName(string? playerName)
        { 
         Name = playerName;
        }
        internal void TakeDamage(int monsterDamage)
        {
            curentHP = monsterDamage;
        }
    }
}
