




namespace AppsLab_020_OOP
{
    public class Player
    {
        private const int maxHp = 100;
        private const int minHp = 0;

        private string Name;
        private int currentHp = maxHp;
        private int PlayerDamage = 20;
        private List<string> inventory = new List<string>();

       
        public bool DealDamage( Monster opponent)
        {
            opponent.TakeDamage(PlayerDamage);
            return true;
        }

        public void SetName(string? PlayerName)
        {
            Name = PlayerName;
        }

        public void TakeDamage(int PlayerDamage)
        {
            int currnetHp = PlayerDamage;
        }
    }
}

