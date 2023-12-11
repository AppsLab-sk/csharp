namespace AppsLab_020_OOP.Fighters
{
    public class Wizard
    {

        public string Name { get; set; }
        public int Health { get; set; }
        public int AttackPower { get; set; }
        public int Mana { get; set; } = 100;

        public Wizard(string name, int health, int attackPower, int mana)
        {
            Name = name;
            Health = health;
            AttackPower = attackPower;
            Mana = mana;
        }

        public bool StillAlive()
        {
            return Health > 0;
        }

        public override string? ToString()
        {
            return Name + "(" + Health + ")";
        }




        public void Attack(Warrior enemy)
        {
            if (Mana > 0)
            {
                enemy.Health -= AttackPower;
                Mana -= 20;
            }
            else
            {
                Mana += 25;
                Console.WriteLine(this + "oddychuje");
            }
        }

        public void Heal()
        {
            if (Mana > 0)
            {
                Health += 50;
                Mana -= 20;
            }
            else
            {
                Rest();
            }
        }

        private void Rest()
        {
           
        }
    }
}
