using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kniznica
{
    internal class Kniha
    {
        public string Nazov { get; set; }
        public string Autor { get; set; }
        public int ISBN { get; set; }
        public int RokVydania { get; set; }
        public int PocetDostupnychKusov { get; set; }
        public KategorieKnih Kategoria { get; set; }

        public Kniha()
        {
        }

        public Kniha(string nazov, string autor, int iSBN, int rokVydania, int pocetDostupnychKusov, KategorieKnih kategoria)
        {
            Nazov = nazov;
            Autor = autor;
            ISBN = iSBN;
            RokVydania = rokVydania;
            PocetDostupnychKusov = pocetDostupnychKusov;
            Kategoria = kategoria;
        }

        public override string ToString()
        {
            return Nazov;
        }
    }
}
