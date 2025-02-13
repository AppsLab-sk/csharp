using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemoni
{
    public class Pokemon
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int MaxHealth { get; set; }
        public int Level { get; set; }
        public Pokemon(string name, int maxHealth,int level)
        {
            this.Name = name;
            this.MaxHealth = maxHealth;
            this.Level = level;
            this.Health = MaxHealth;
        }
        public int Attack1()
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
            return rnd.Next(40, 60) * Level;
        }
        public bool TakeDamage(int damage)
        {
            Health -= damage;
            if (Health < 0)
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
            Random rnd = new Random();
            return rnd.Next(20, 71) * Level;
        }



    }
}
