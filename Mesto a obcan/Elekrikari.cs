using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mesto_a_obcan
{
    public class Elekrikari : Obcan
    {
        protected string typkablu;

        public string Typkablu
        {
            get { return typkablu; }
            set { typkablu = value; }

        }

       
        public Elekrikari(string meno, int vek, string typkablu) : base(meno, vek)
        {
           this.typkablu = typkablu;
        }
        public Elekrikari()
        {

        }
      
        
        public override void VypisInfo()
        {
            Console.WriteLine("Meno: " + meno + " Vek " + vek + " " + typkablu + " Stav: " + stav);
        }
    }
}
