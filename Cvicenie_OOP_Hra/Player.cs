using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Cvicenie_OOP_Hra
{
    public class Player
    {
        public string Name { get; set; }
        public int AttackPower { get; set; }
        public int HP { get; set; }
        public int Mana { get; set; }
        public int CritChange { get; set; }
        public int RefilManaChance { get; set; }

        public Player()
        {

        }

        public Player(string name, int attackPower, int hP, int mana, int CriticalChange, int refilManaChance)
        {
            Name = name;
            AttackPower = attackPower;
            HP = hP;
            Mana = mana;
            CritChange = CriticalChange;
            RefilManaChance = refilManaChance;
        }


        public void DamagePlayer(Player player)
        {
            int damageMultipayer = 1;
            Random random = new Random();
            int randomNumber = random.Next(0, 100);
            if (randomNumber <= this.CritChange)
            {
                damageMultipayer = 2;
                Console.WriteLine(this.Name + " dal kriticky zasah!");
            }

            var HPofEnemy = player.HP;
            int AttackOfCurrentPlayer = this.AttackPower;
            int HPofEnemyAfterFight = HPofEnemy - AttackOfCurrentPlayer;
            player.HP = HPofEnemyAfterFight;

        }
        public void RefilMana(int newMana)
        {
            this.Mana += newMana;
        }
        public bool Heal()
        {
           
           Random random = new Random();
           int randomNumber = random.Next(0, 100);
            if (randomNumber <= this.RefilManaChance)
            {
                this.Mana += 50;
                Console.WriteLine(this.Name + " Pridal si Manu!");
            }


            if (this.Mana > 0)
            {
                int HpOfPlayer = this.HP;
                int ManaOfPlayer = this.Mana;
                int HPofPlayerPlusMana = HpOfPlayer + ManaOfPlayer;
                this.HP = HPofPlayerPlusMana;
                this.Mana = 0;
                return true;
            }
            else
            {
                return false;
            }
   
        }
    }
}
