using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Claims;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Cvicenie_OPP_Hra
{
    internal class Hra
    {
        public string PlayerName { get; set; }
        
        public int Mana { get; set; }
      
        public int HP { get; set; }
       
        public int Power { get; set; }
        public int Critchanges { get; set; }

        public Hra()
        {

        }
        public Hra(string playerName, int mana, int hP, int power, int critchanges)
        {
            PlayerName = playerName;
            Mana = mana;
            HP = hP;
            Power = power;
            Critchanges = critchanges;  
        }
        public void Damage(Hra Hra)
        {

            int damagemultiplayer = 1;

            Random random = new Random();
            int randomnuber = random.Next(0,100);
            if (randomnuber <= this.Critchanges) 
            {
                damagemultiplayer = 2;
                Console.WriteLine(this.PlayerName + " dal kriticky zasah");
            }

            int HPofEnemy = Hra.HP;
            int AttackOfCurrentPlayer = this.Power * damagemultiplayer;
            int HPofEnemyAfterFight = HPofEnemy - AttackOfCurrentPlayer;
            Hra.HP = HPofEnemyAfterFight;
        }
        public bool Heal() 
        {
            if (this.Mana > 0)
            {
                int HPofplayer = this.HP;
                int Manaofplayer = this.Mana;
                int HPofPlayerAfterHeal = Manaofplayer + HPofplayer;
                this.HP = HPofPlayerAfterHeal;
                this.Mana = 0;
                return true;
            }
            else 
            { 
              return false;
            }
            
        }
        public void Refilmana(int minMana) 
        {
            this.Mana = minMana;         
        }
       
    }  
}
 