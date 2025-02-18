using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObcanMesto
{
    public class Obcan
    {
        protected string meno;
        protected int vek;
        protected StavObcana stav;

        public string Meno
        {
            get { return meno; } 
            set
            {
                meno = value;
            }
        }

        public Obcan(string meno, int vek)
        {
            this.meno = meno;
            this.vek = vek;
        }

        public int Vek
        {
            get { return vek; }
            set { vek = value; }
        }

        public StavObcana Stav
        {
            get { return stav; }
            set { stav = value; }
        }
        public Obcan()
        {
            
        }

        public virtual void VypisInfo()
        {
            Console.WriteLine("Meno: " + meno + ", Vek: " + vek + ", Stav: " + stav);
        }

        public void VypisVek() 
        {
            Console.WriteLine("Vek: " + vek);
        }
    }
    public enum StavObcana
    {
        Domaci,
        Cudzinec,
        Turista
    }
}
