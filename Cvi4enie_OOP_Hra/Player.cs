using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Cvi4enie_OOP_Hra
{
    public class Player
    {
        public string Name { get; set; }
        public int HP { get; set; }
        public int Mana { get; set; }
        public int AttackPower { get; set; }
        public int Critchange { get; set; }


        public void DamagePlayer(Player player)
        {
            int damageMultiPlayer = 1;

            Random random = new Random();
            int randomNumber = random.Next(0, 100);
            if (randomNumber <= this.Critchange)
            {
                damageMultiPlayer = 2;
                Console.WriteLine(this.Name + "dal krititcky zasah");
            }

            int HPofEnemy = player.HP;
            int AttackOfCurrentPlayer = this.AttackPower * damageMultiPlayer;
            int HpofEnemyAfterFight = HPofEnemy - AttackOfCurrentPlayer;
            player.HP = HpofEnemyAfterFight;
        }

        public bool Heal()
        {
            if (this.Mana >= 0)
            {



                int HPOfPlayer = this.HP;
                int ManaOfPlayer = this.Mana;
                int HPOfPlayerAfterHeal = HPOfPlayer + ManaOfPlayer;
                this.Mana = 0;
                this.HP = HPOfPlayer;
                return true;
            }
            else
            {
                return false;
            }
        }
            public void RefilMana(int newMana)
            {
                this.Mana = newMana;
            Random random = new Random();
            int randomNumber = random.Next(0, 100);
            if (randomNumber <= this.Mana)
                 {
                    Console.WriteLine(this.Mana + " zasah ");
                 }
            }
        
    }
}
