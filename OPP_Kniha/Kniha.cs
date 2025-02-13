using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP_Kniha
{
    public class Kniha
    {
        private int pocet_Stran;
        private string nazov;

        public Kniha(int pocet_Stran, string nazov)
        {
            this.pocet_Stran = pocet_Stran;
            this.nazov = nazov;
        }
        public string Nazov 
        { get { return nazov; } 
            set { nazov = value; } }

        public int Pocet_Stran 
        { get { return pocet_Stran; } 
            set { if (value > 0) pocet_Stran = value; else Console.WriteLine("Nespravny pocet stran"); } }



    }
    
  
}
