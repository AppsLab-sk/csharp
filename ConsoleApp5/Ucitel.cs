using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObcanMesto
{
    class Ucitel
    {
        public string meno;
        public int vek;


        public Ucitel(string meno, int vek)
        {
            this.meno = meno;
            this.vek = vek;
        }


        public void VypisInfo()
        {
            Console.WriteLine(meno + "," + vek + " rokov, uci studentov.");
        }
        public Ucitel()
        {
            
        }
    }
}
