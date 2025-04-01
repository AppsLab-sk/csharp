namespace PokemonGame
{
    public class Pokemon
    {
        public string Name { get; set; }
        public int MaxHealth { get; set; }
        public int Health { get; set; }
        public int Level { get; set; }
        public int Energy { get; set; }
        public int MaxEnergy { get; set; }

        public Pokemon(string name, int maxHealth, int level, int maxEnergy)
        {
            this.Name = name;
            this.MaxHealth = maxHealth;
            this.Level = level;
            this.Health = MaxHealth;
            this.MaxEnergy = maxEnergy;
            this.Energy = MaxEnergy;
        }

        public int Attack1()
        {
            Random rnd = new Random();
            return rnd.Next(10, 30) * Level;
        }

        public int Energy_Attack1()
        {
            Random rnd = new Random();
            return rnd.Next(10, 30);
        }

        public int Attack2()
        {
            Random rnd = new Random();
            return rnd.Next(30, 70) * Level;
        }

        public int Energy_Attack2()
        {
            Random rnd = new Random();
            return rnd.Next(30, 70);
        }

        public int Attack3()
        {
            Random rnd = new Random();
            return rnd.Next(50, 100) * Level;
        }

        public int Energy_Attack3()
        {
            Random rnd = new Random();
            return rnd.Next(50, 100);
        }

        public bool TakeDamage(int damage)
        {
            Health -= damage;
            if (Health <= 0)
            {
                Health = 0;
                return false;
            }
            return true;
        }

        public void TakeHeal(int heal)
        {
            Health += heal;
            if (Health >= MaxHealth)
            {
                Health = MaxHealth;
            }
        }

        public bool TakeEnergy(int energy)
        {
           Energy -= energy;
            if (Energy <= 0)
            {
                Energy = 0;
                return false;
            }
            return true;
        }

        public int Heal()
        {
            Random rnd = new Random();
            return rnd.Next(40, 80) * Level;
        }
    }
}
