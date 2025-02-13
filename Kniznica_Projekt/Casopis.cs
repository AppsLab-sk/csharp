using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kniznica_Projekt
{
    internal class Casopis : Kniha
    {
        public string Tema { get; set; }
        public int MesiacVydania { get; set; }

        public Casopis(string idKnihy, string nazov, string autor, int rok, bool jeDostupna, string tema, int mesiacVydania) : base(idKnihy, nazov, autor, rok, jeDostupna)
        {
            this.Tema = tema;
            this.MesiacVydania = mesiacVydania;
        }
        public override void VypisInfo() 
        {
            Console.WriteLine($"Tema: {Tema} MesiacVydania: {MesiacVydania}");      
        }
    }
}
