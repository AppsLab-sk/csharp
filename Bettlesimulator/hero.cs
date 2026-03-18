using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Cvicenie_BattleSimulator.Monster;

namespace Cvicenie_BattleSimulator
{
    internal class Hero
    {
        public string Name { get; set; } = "Gumkac";
        public int HP { get; set; } = 100;
        public int DMG { get; set; } = 10;

        public int Eng { get; set; } = 100;
        public int Armor { get; set; } = 15;

        public bool HeroAttack(Monster monster)
        {
            if (Eng - 20 >= 0)
            {
                Eng -= 20;
                monster.HP -= this.DMG;
                return true;
            }
            else

            {
                Eng = Eng + 50;
                return false;
            }
        }
        public bool HeroAttack2(MonsterSpecial monster2)
        {
            if (Eng - 20 >= 0)
            {
                Eng -= 20;
                monster2.HP -= this.DMG;
                return true;
            }
            else

            {
                Eng = Eng + 50;
                return false;
            }
        }
        public void TakeDamage(int damage)
        {
            int finalDamage = damage - Armor;

            if (finalDamage < 0)
                finalDamage = 0;

            HP -= finalDamage;
        }

        public bool HeroDMG(Monster monster)
        {
            if (Eng - 20 >= 0)
            {
                Eng -= 20;
                monster.HP -= this.DMG;
                return true;
            }
            else
            {
                Eng += 50;
                return false;
            }
        }

        public bool HeroDMG2(MonsterSpecial monster2)
        {
            if (Eng - 20 >= 0)
            {
                Eng -= 20;
                monster2.HP -= this.DMG;
                return true;
            }
            else
            {
                Eng += 50;
                return false;
            }
        }





    }
}