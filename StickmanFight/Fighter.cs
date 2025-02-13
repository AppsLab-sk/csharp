using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StickmanFight
{
    public class Fighter
    {
        public string name {  get; set; }
        public int MaxHealth { get; set; }
        public int Healt { get; set; } 
        public int Level {  get; set; }

        public Fighter(string name, int maxHealth, int level)
        {
            this.name = name;
            this.MaxHealth = maxHealth;
            this.Level = level;
            this.Healt = maxHealth;
        }

        public int Attack1()
        {
            Random random = new Random();
            return random.Next(10, 41) * Level;
        }
        public int Attack2()
        {
            Random random = new Random();
            return random.Next(40, 81) * Level;
        }
        public int Attack3()
        {
            Random random = new Random();
            return random.Next(80, 95) * Level;
        }

        public int Heal()
        {
            Random random = new Random();
            int healValue = random.Next(20, 71) * Level;
            if (Healt <= 100)
            {
                if (Healt + healValue > MaxHealth)
                {
                    Healt = MaxHealth;
                }
                else
                {
                    Healt += healValue;
                }
            }

            return healValue;
        }

        

        public bool TakeDamage(int damage)
        {
            Healt -= damage;
            if (Healt <= 0)
            {
                Healt = 0;
                return false;
            }
            return true;
        }
    }
}
