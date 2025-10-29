
namespace OOP
{
    public class player
    {
        private string Name;
      private const int MaxHp = 100;
       private const int MinHp = 0;
        private int currentHP = MaxHp;
        private int Pladamage = 20;
       private List <string> Inventar = new List<string>();
        internal void TakeDamage(int damage)
        {
            currentHP -= damage;
        }
        public bool DealDamage( Monster opponent)
        {
           opponent.TakeDamage(Pladamage);
            return true;
        }

        internal void SetName(string? pname)
        {
            Name = pname;
        }
    }
}
