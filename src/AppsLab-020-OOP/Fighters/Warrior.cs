namespace AppsLab_020_OOP.Fighters
{
    public class Warrior
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int AttackPower { get; set; }

        public Warrior(string name, int health, int attackPower)
        {
            Name = name;
            Health = health;
            AttackPower = attackPower;
        }

        public bool StillAlive()
        {
            return Health > 0;
        }

        public override string? ToString()
        {
            return Name + "(" + Health + ")";
        }

        public  void Attack(Wizard enemy)
        {
            enemy.Health -= AttackPower;
        }

        public  void Heal()
        {
            Health += 25;
        }
    }
}
