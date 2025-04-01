using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Game
{
    public class Pokemon
    {
        private string v;

        public string Name { get; set; }
        public int MaxHealth { get; set; }
        public int Health { get; set; }
        public int Level { get; set; }

        public Pokemon(string name, int maxHealth, int level)
        {
            Name = name;
            MaxHealth = MaxHealth;  
            Health = maxHealth;
            Level = level;
        }

        public Pokemon(string v)
        {
            this.v = v;
        }

        public int Attack1()
        {
            Random random = new Random();
            return random.Next(10, 91) * Level;
        }

        public int Attack2()
        {
            Random random = new Random();
            return random.Next(30, 71) * Level;
        }

        public int Attack3()
        {
            Random random = new Random();
            return random.Next(40, 61) * Level;
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

        public int Heal()
        {
            Random random = new Random();
            return random.Next(20, 71) * Level;
        }
    }
}

