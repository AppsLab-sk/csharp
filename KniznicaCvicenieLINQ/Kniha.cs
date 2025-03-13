using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KniznicaCvicenieLINQ
{
    public class Kniha
    {
        public string Autor { get; set; }
        public int RokVydania { get; set; }
        public bool JePreDospelych { get; set; }

        public Kniha()
        {
        }

        public Kniha(string autor, int rokVydania, bool jePreDospelych)
        {
            Autor = autor;
            RokVydania = rokVydania;
            JePreDospelych = jePreDospelych;
        }
    }
}
