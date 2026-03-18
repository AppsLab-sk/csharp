using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cvicenie_BattleSimulator
{
    internal class Monster
    {

        public string RaceType { get; set; }
        public int HP { get; set; }
        public int DMG { get; set; }

        public Monster(string raceType, int hP, int dMG)
        {
            RaceType = raceType;
            HP = hP;
            DMG = dMG;
        }

        public void MonsterAttack(Hero hero)
        {
            hero.HP -= this.DMG;
        }

    }
}