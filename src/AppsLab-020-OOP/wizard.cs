using AppsLab_020_OOP;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AppsLab_020_OOP
{
   public class Wizard
    {

        public string Name { get; set; }
        public int Health { get; set; }
        public int attackpower { get; set; }
        public int mana { get; set; }


        public void Attack(Wizard enemy)
        {

            if (mana > 0)
            {
                enemy.Health = Math.Max(0, enemy.Health - attackpower);
                mana -= 20;
            }
            else
            {
                mana += 25;
                Console.WriteLine(this + "odychuje");
            }
        }
        public void Attack(Warrior enemy)
        {

            if (mana > 0)
            {
                enemy.Health = Math.Max(0, enemy.Health - attackpower);
                mana -= 20;
            }
            else
            {
                mana += 25;
                Console.WriteLine(this + "odychuje");
            }
        }
        public void Heal(Wizard wizard) 
        {
            wizard.Health += 20;
        }
        public bool StillAlive()
        {
            return Health > 0;
        }
        public override string? ToString()
        {
            return Name + "(" + Health + ")";
        }
    }    
}