using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obcan_a_mesto
{
    class ucitel : Obcan
    {
        public ucitel()
        {
        }

        private ucitel(string name, int age) : base(name, age){ }
 
        public void VypisInfo()
        {
            Console.WriteLine("Meno" + Name + ", Vek " + Age + ",sere dzeci." + " ,Stav: " + stav);
        }

    }
}

