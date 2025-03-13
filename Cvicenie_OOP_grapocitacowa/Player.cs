using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cvicenie_OOP_grapocitacowa
{
    public class Player
    {
        public string ClassType { get; set; }
        public int Power { get; set; }
        public int HP { get; set; }
        public int Mana { get; set; }
        public int CritChance { get; set; }
        public int RefilManaChance { get; set; }

        public Player()
        {

        }

        public Player(string classType, int power, int hP, int mana, int critChance, int refilManaChance)
        {
            ClassType = classType;
            Power = power;
            HP = hP;
            Mana = mana;
            CritChance = critChance;
            RefilManaChance = refilManaChance;
        }
        
        public void DamagePlayer(Player player)
        {
            int damageMultiplier = 1;

            Random random = new Random();
            int randomNumber = random.Next(0, 100);
            if (randomNumber <= this.CritChance)
            {
                damageMultiplier = 2;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(this.ClassType + " hit Critical!");
                Console.ForegroundColor = ConsoleColor.White;
            }
            

            int HPofEnemy = player.HP;
            int AttackofCurrentPlayer = this.Power * damageMultiplier;
            int HPofEnemyAfterFight = HPofEnemy - AttackofCurrentPlayer;
            player.HP = HPofEnemyAfterFight;
        }

        public bool HealPlayer()
        {
            
            Random random = new Random();
            int randomNumber = random.Next(0, 100);
            if (randomNumber <= this.RefilManaChance)
            {
                this.Mana += 50;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(this.ClassType + " has refilled his Mana!");
                Console.ForegroundColor = ConsoleColor.White;
            }

            if (this.Mana > 0)
            {
                int HpOfPlayer = this.HP;
                int ManaOfPlayer = this.Mana;
                int HPofPlayerAfterHeal = HpOfPlayer + ManaOfPlayer;
                HpOfPlayer = HPofPlayerAfterHeal;
                this.Mana = 0;
                return true;
            }
            else
            { 
                return false; 
            }
           
        }

        public void RefilMana(int newMana)
        {
            this.Mana += newMana;
        }
    }
}
