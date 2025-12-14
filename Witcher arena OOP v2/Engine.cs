using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Witcher_arena_OOP_v2
{
    internal class Engine
    {
        Player player = new Player();
        Skeleton skeleton = new Skeleton();
        Cupik cupik = new Cupik();


        private int roundLoop = 0;
        private int fightLoop = 0;

        private bool endGame = false;
        public bool endRound = false;

        private string roundMonster = "";

        private string PickMonster(Random _random)
        {
            int randomNumber = _random.Next(2);

            if (randomNumber == 0) 
            {
                roundMonster = "CupikGrr";
            }
            else if (randomNumber == 1) 
            {
                roundMonster = "SkeletonGrr";
            }

            return roundMonster;
        }

        private void FightLoop(Player player, Skeleton skeleton, Cupik cupik)
        {


        }

        private void ChecingIfPlayerIsAlive(Player player)
        {
            if (player.currentHp >= 0)
            {
                endGame = true;
            }
        }
        
        private void EndingLoops()
        {
            if (endRound == true) 
            { 
            
            }
            if (endRound == true) 
            { 
            
            }
        }

        public void gg(Characters characters, Player player)
        {
            Random rnd = new Random();
            string monster = PickMonster(rnd);

            
            characters.Test(player);
           
            Console.WriteLine(roundMonster);
            Console.WriteLine(player.currentHp);
        }
    }
}
