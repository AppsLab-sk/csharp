using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace AppsLab_020_OOP
{
    public class Warrior
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int AttackPower { get; set; }
        public int Bandages { get; set; }

        public Warrior(string name, int health, int attackPower, int bandages)
        {
            Name = name;
            Health = health;
            AttackPower = attackPower;
            Bandages = bandages;
        }

        public void Attack(Mage mage)
        {
            mage.Health -= AttackPower;
        }
        public void Heal()
        {
            if (Health <= 50 && Bandages >= 1)
            {
                Health += 50;
                Bandages -= 1;
                Console.WriteLine(this + Name + " is using a bandage.");
            }
            else if (Bandages == 0)
            {
                Health += 0;
            }
        }
        public bool StillAlive()
        {
            return Health > 0;
        }
        public override string ToString()
        {
            return Name + " (" + Health + ")";
        }
    }
}
