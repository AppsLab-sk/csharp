using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
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

        public int CritChance { get; set; }

        public Hra()
        {
        }

        public Hra(string playerName, int mana, int hP, int power, int critchance)
        {
            PlayerName = playerName;
            Mana = mana;
            HP = HP;
            Power = power;
            CritChance = critchance;
        }
        public void Damage(Hra Hra)
        {
            int damagemultiplier = 1;


            Random random = new Random();
            int randomnumber = random.Next(0, 100);
            if (randomnumber <= this.CritChance)
            {
                damagemultiplier = 2;
                Console.WriteLine(this.PlayerName + " CRIT!");
            }

            int HPofEnemy = Hra.HP;
            int AttackOfCurrentPlayer = this.Power * damagemultiplier;
            int HPofEnemyAfterFight = HPofEnemy - AttackOfCurrentPlayer;
            Hra.HP = HPofEnemyAfterFight;
        }

        public bool heal()
        {
            if (this.Mana > 0)
            {
                int HPOfplayer = this.HP;
                int ManaOfplayer = this.Mana;
                int HPOfPlayerAfterHeal = HPOfplayer + ManaOfplayer;
                this.HP = HPOfPlayerAfterHeal;
                this.Mana = 0;
                return true;
            }
            else
            {
                return false;
            }

        }
        public void RefilMana(int newmana)
        {
            this.Mana += newmana;
        }
    } 
}
