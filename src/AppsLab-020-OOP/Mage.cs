using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AppsLab_020_OOP
{
    public class Mage
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int AttackPower { get; set; }
        public int Mana { get; set; }
        public int HealthPots { get; set; }

        public void Attack(Warrior warrior)
        {

            if (Mana > 20)
            {
                warrior.Health -= AttackPower;
                Mana -= 20;
            }
        }
        public void ManaRegen()
        { 
        if (Mana <= 0)
            {
           Mana += 25;
           Console.WriteLine(this + Name + "is resting.");
        }
        public void Heal()
        {
            if (Health <= 50)
            {
                Health += 20;
                HealthPots -= 1;
                    Console.WriteLine("Using Health potion.");
            }
            else if (HealthPots <= 0)
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
            return Name + "(" + Health + ")"; 
        }
        public void Ultimate(Warrior warrior)
        {
            if (Health <= 20 && Mana >=40)
            {
                Console.WriteLine(Name + "is unleashing ultimate!");
                Mana -= 40;
                warrior.Health -= 3 * AttackPower;
            }
            else
            {
                warrior.Health -= AttackPower;
                Mana -= 20;
            }
        }
    }
}
