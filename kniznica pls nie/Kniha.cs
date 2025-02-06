using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kniznica_pls_nie
{
    internal class Kniha
    {
        public string IdKnihy { get; set; }
        public string Nazov { get; set; }
        public string Autor { get; set; }
        public int Rok { get; set; }
        public bool JeDostupna { get; set; }

        public Kniha(string idKnihy, string nazov, string autor, int rok, bool jeDostupna)
        {
            IdKnihy = idKnihy;
            Nazov = nazov;
            Autor = autor;
            Rok = rok;
            JeDostupna = jeDostupna;
        }

        public void VipisInfo()
        {
            Console.WriteLine($" Idknihy: {IdKnihy} Nazov: {Nazov} Autor: {Autor} Rok: {Rok} je dostupna? {JeDostupna}");
        }
    }
}
