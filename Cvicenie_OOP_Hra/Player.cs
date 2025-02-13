using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
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
        public int CritChance { get; set; }

        public Player(string name, int attackPower, int hP, int mana, int critChance)
        {
            Name = name;
            AttackPower = attackPower;
            HP = hP;
            Mana = mana;
            CritChance = critChance;
        }

        public void DamagePlayer(Player player)
        {
            int damageMultiplier = 1;

            Random random = new Random();
            int randomNumber = random.Next(0, 100);
            if (randomNumber <= this.CritChance)
            {
                damageMultiplier = 2;
                Console.WriteLine(this.Name + " dal kriticky zasah! ");

                int HPofEnemy = player.HP;
                int AttackofCurrentPlayer = this.AttackPower * damageMultiplier;
                int HPofEnemyAfterFight = HPofEnemy - AttackofCurrentPlayer;
                player.HP = HPofEnemyAfterFight;

            }

        }
        public bool Heal()
        {
            if (this.Mana > 0)
            {

                int HPOfPlayer = this.HP;
                int ManaOfPlayer = this.Mana;
                int HPOfPlayerAfterHeal = HPOfPlayer + ManaOfPlayer;
                this.Mana = 0;
                this.HP = HPOfPlayerAfterHeal;
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
