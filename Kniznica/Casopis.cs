using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kniznica
{
    public class Casopis : Kniha
    {
        public string tema;
        public int mesiacVydania;

        public string Tema
        {
            get { return tema; }
            set { tema = value; }
        }

        public int MesiacVydania
        {
            get { return mesiacVydania; }
            set { mesiacVydania = value; }
        }

        public Casopis(string idKnihy, string nazov, string autor, int rok, bool jeDostupna, string tema, int mesiacVydania)
                                                  : base(idKnihy, nazov, autor, rok, jeDostupna)
        {
            this.tema = tema;
            this.mesiacVydania= mesiacVydania;

        }

        public void VypisInfo()
        {
            Console.WriteLine($"idKnihy: {this.IdKnihy}, Nazov: {this.Nazov}, Autor: {this.Autor},Rok vydania: {this.Rok}" +
                $"    , Je dostupna: {this.JeDostupna},Tema: {this.Tema}, mesiac vydania: {this.MesiacVydania} ");
        }
    }
}
