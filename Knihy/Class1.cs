using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knihy
{
    public class Kniha1
    {
        public string Autor { get; set; }
        public int RokVydania { get; set; }
        public bool JePreDospelych { get; set; }

        public Kniha1()
        {

        }

        public Kniha1(string autor, int rokVydania, bool jePreDospelych)
        {
            Autor = autor;
            RokVydania = rokVydania;
            JePreDospelych = jePreDospelych;
        }






    }
}
