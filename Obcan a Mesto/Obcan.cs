using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obcan_a_Mesto
{
    public class Obcan
    {
        protected string meno;
        protected int vek;
        protected StavObcana stav;

        public string Meno
        {
            get { return meno; }
            set { meno = value; }
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
        public Obcan(string meno, int vek)
        {
            Meno = meno;
            Vek = vek;
        }
        public virtual void VypisInfo()
        {
            Console.WriteLine("Meno: " + Meno + ", Vek: " + Vek + "Stav: " + stav);
        }
       
    } 
    public enum StavObcana
        {
            Domaci,
            Cudzinec,
            Turista
        }
}
