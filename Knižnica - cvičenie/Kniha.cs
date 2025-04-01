using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Knižnica___cvičenie
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
        public void VypisInfo()
        {
            Console.WriteLine($" IdKnihy: {IdKnihy}, Nazov: {Nazov}, Autor: {Autor}, Rok: {Rok}, JeDostupna: {JeDostupna} ");
        }
    }
}
