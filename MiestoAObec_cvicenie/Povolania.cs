using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiestoAObec_cvicenie
{


    namespace PovolanoeMenoMesto_cvicenie
    {
        public class Povolania
        {
            public string Lekar { get; set; }
            public string Programator { get; set; }

            public Povolania(string Lekar, string Programator)
            {
                this.Lekar = Lekar;
                this.Programator = Lekar;
            }
            public void VypisInfo()
            {
                Console.WriteLine(Lekar + ",kt. lieci ludi");
                Console.WriteLine(Programator + ",kt. pracuje na PC");
            }
        }


    }

}
