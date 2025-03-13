using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Kniznica
{
    public class Kniha
    {
        public string Nazov { get; set; }
        public string Autor { get; set; }
        public string ISBN { get; set; }
        public int RokVydania { get; set; }
        public int PocetDostupnychKusov { get; set; }
        public BookCategory Category { get; set; }

        public Kniha(string nazov, string autor, string iSBN, int rokVydania, int pocetDostupnychKusov, BookCategory bookCategory)
        {
            Nazov = nazov;
            Autor = autor;
            ISBN = iSBN;
            RokVydania = rokVydania;
            PocetDostupnychKusov = pocetDostupnychKusov;
            Category = bookCategory;
        }
    }
}
