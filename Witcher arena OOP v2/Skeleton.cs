using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Witcher_arena_OOP_v2
{
    internal class Skeleton : Characters
    {
        public Skeleton() : base()
        {
            damage = 20;
            currentHp = 100;
        }
    }
}
