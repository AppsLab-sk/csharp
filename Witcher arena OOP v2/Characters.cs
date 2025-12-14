using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Witcher_arena_OOP_v2
{
    internal class Characters
    {
        protected decimal currentHp = 100;
        protected decimal damage = 20;
        protected bool testie = false;

        public Characters()
        {
            
        }

        public virtual void DealDamage(Player player)
        {
            player.currentHp -= damage;
        }
        public virtual void TakeDamage(Player player)
        {
            currentHp -= player.damage;
        }

        public virtual void ItsDead(Engine engine)
        {
            if (currentHp <= 0) 
            {
                engine.endRound = true;
            }
        }

        public virtual void Test(Player player) 
        {
            testie = true;
            if (testie == true)
            {
                TakeDamage(player);
            }
        
            
        }

        //alt + šipka hore, ctrl + alt
    }
}
