using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Witcher_Arena
{
    internal class Dragon : Monster
    {
        private const int DAMAGE_MODIFYER = 2;


        public Dragon(int hp, int damage) : base(hp, damage * DAMAGE_MODIFYER)
        {
        }

        internal override void DoDamage(Player player)
        {
            base.DoDamage(player);
        }
    }
}
