using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObcaniaAmesto
{
    class Ucitel : Citizen
    {
        private Ucitel(string name, int age) : base(name, age)
        {
        }

        public Ucitel()
        {

        }

        public new void VypisInfo()
        {
            Console.WriteLine("Meno: " + Name + ", Vek: " + Age + ", uci detiska nepodarene." + " Stav: " + Stav);
        }
    }
}
