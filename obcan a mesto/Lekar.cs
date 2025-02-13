using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obcan_a_mesto
{

    public class Lekar : Obcan
    {
        public Lekar()
        {
        }

        private Lekar(string name, int age) : base(name, age){ }
        public new void VypisInfo()

        {
            Console.WriteLine(Name + ", " + Age + ", lieci sople." + " ,Stav: " + stav);
        }

    }
}
