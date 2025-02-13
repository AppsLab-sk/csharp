using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cvicenie_Pat
{
    public class Obcan
    {
        protected string meno;
        protected int vek;
        protected StavObcana stav;

        public StavObcana Stav
        {
            get { return stav; }
            set { stav = value; }
        }

        public string Meno 
        {
            get { return meno; } 
            set { meno = value; }
        } 


        public int Vek 
        {
            get { return vek; } set { vek = value; }          
        }

        public Obcan()
        {
        }

        public Obcan(string meno, int vek)
        {
            Meno = meno;
            Vek = vek;
           
        }
        public virtual void VypisInfo() 
        {
            var st = new StavObcana();
            Console.WriteLine("Meno: " + Meno + " || Vek: " + Vek + " || Stav obcana " + stav);

        }
    }
}

public enum StavObcana
{ 
    Domaci,
    Cudzinci,
    Un_turista,
}




