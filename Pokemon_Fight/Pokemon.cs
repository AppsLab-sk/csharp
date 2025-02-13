using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Fight
{
    public class Pokemon
    {
        public string Name { get; set; }

        public int Health { get; set; }
        public int MaxHealth { get; set; }
        public int Level { get; set; }

        public Pokemon(string name, int maxHealth, int level)
        {
            Name = name;
            this.Health = maxHealth;
            MaxHealth = maxHealth;
            Level = level;
        }

        public int Attack() 
        { 
          Random rnd = new Random();

            return rnd.Next(10, 91) * Level;
        }

        public int Attack2()
        {
            Random rnd = new Random();

            return rnd.Next(30, 71) * Level;
        }

        public int Attack3()
        {
            Random rnd = new Random();

            return rnd.Next(40, 61) * Level;
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
        public int Heal() 
        {
            Random rnd = new Random();
            return rnd.Next(20, 71) * Level;
            
        }
        public void TakeHeal(int heal)
        {
            Health += heal;
            if (Health >= MaxHealth)
            {
                Health = MaxHealth;
                
            }
            
        }
    }
}
