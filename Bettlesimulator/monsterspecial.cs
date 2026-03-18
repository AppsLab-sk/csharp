using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cvicenie_BattleSimulator
{
    internal class MonsterSpecial
    {
        public string RaceType { get; set; }
        public int HP { get; set; }
        public int DMG { get; set; }

        public MonsterSpecial(string raceType, int hp, int dmg)
        {
            RaceType = raceType;
            HP = hp;
            DMG = dmg;
        }

        public void MonsterAttack(Hero hero)
        {
            hero.TakeDamage(this.DMG);
            this.DMG += 1;
        }
    }

}