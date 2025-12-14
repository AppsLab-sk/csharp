using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Witcher_arena_OOP_v2
{
    internal class Player
    {
        
        
         public int  damage = 20;
         public decimal currentHp = 100;
         private int maxHp = 100;
        

        public  void DealDamage(decimal monsterHp)
        {
            monsterHp -= damage;  
        }
        public  void TakeDamage(decimal monsterDamage)
        {
            currentHp -= damage;
        }

    }
}
