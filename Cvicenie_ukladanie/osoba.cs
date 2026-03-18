using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cvicenie_ukladanie
{
    public class osoba
    {
        public string Meno {  get; set; }
        public int Vek {  get; set; }

        public osoba(string meno,int vek    )
        {
            Meno = meno;
            Vek = vek;
        }
        public string udajeodelenelenciarkou()
        {
            string line;
            line = Meno;
            return line;
        }
    }
}
