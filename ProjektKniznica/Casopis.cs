using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektKniznica
{
    public class Casopis : Kniha
    {
        public string tema { get; set; }
        public int mesiacVydania { get; set; }

        public Casopis(string idKnihy, string nazovKnihy, string autor, int rok, bool jeDostupna, string tema, int mesiacVydania) :
            base(idKnihy, nazovKnihy, autor, rok, jeDostupna)
        {
            this.tema = tema;
            this.mesiacVydania = mesiacVydania;
        }

        public void VypisInfo()
        {
            Console.WriteLine($"CASOP>> ID: {this.idKnihy}, NAZOV: {this.nazovKnihy}, AUTOR: {this.autor}, ROK: {this.rok}, " +
                $"DOSTUPNA: {this.jeDostupna}, TEMA: {this.tema}, MESIAC VYDANIA: {this.mesiacVydania}");
        }
    }

}
