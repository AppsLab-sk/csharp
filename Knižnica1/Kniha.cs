using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knižnica1
{
    class Kniha
    {
        public KategoriaKnihy Kategoria { get; set; }
        public string Nazov { get; set; }
        public string Autor { get; set; }
        public int ISBN { get; set; }
        public int Rok { get; set; }
        public int Kusy { get; set; }
    

    public Kniha(KategoriaKnihy kategoria,string nazov, string autor, int iSBN, int rok, int kusy)
        {
            Kategoria = kategoria;
            Nazov = nazov;
            Autor = autor;
            ISBN = iSBN;
            Rok = rok;
            Kusy = kusy;
        }
    }
}