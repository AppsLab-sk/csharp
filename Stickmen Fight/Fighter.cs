using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stickmen_Fight
{
    public class Fighter
    {
        public string name { get; set; }
        public int maxHealth {  get; set; }
        public int health { get; set; }
        public int level { get; set; }

        public Fighter(string name, int maxHealth, int level)
        {
            this.name = name;
            this.maxHealth = maxHealth;
            this.level = level;
            this.health = maxHealth;
        }

        public int Attack1()
        {
            Random random = new Random();
            return random.Next(10, 91) * level;
        }

        public int Attack2() 
        {
            Random random = new Random();
            return random.Next(10, 71) * level;
        }

        public int Attack3() 
        {
            Random random = new Random();
            return random.Next(40, 61) * level;
        }

        public int Heal()
        {
            Random random = new Random();
            int healValue = random.Next(20, 71) * level;
            return healValue;
        }

        public bool TakeDamage(int damage)
        {
            health -= damage;
            if (health <= 0)
            {
                health = 0;
                return false;
            }
            return true;
        }

        public void TakeHeal(int healValue)
        {
            if (health <= maxHealth)
            {
                if (health + healValue > maxHealth)
                {
                    health = maxHealth;
                }
                else
                {
                    health += healValue;
                }
            }
        }
    }
}