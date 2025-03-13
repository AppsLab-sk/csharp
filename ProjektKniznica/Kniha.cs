using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektKniznica
{
    public class Kniha
    {
        public string idKnihy { get; set; }
        public string nazovKnihy { get; set; }
        public string autor { get; set; }
        public int rok { get; set; }
        public bool jeDostupna { get; set; }

        public Kniha(string idKnihy, string nazovKnihy, string autor, int rok, bool jeDostupna)
        {
            this.idKnihy = idKnihy;
            this.nazovKnihy = nazovKnihy;
            this.autor = autor;
            this.rok = rok;
            this.jeDostupna = jeDostupna;
        }

        public void VypisInfo()
        {
            Console.WriteLine($"KNIHA>> ID: {this.idKnihy}, NAZOV: {this.nazovKnihy}, AUTOR: {this.autor}, ROK: {this.rok}, " +
                $"DOSTUPNA: {this.jeDostupna}");
        }
    }
}
