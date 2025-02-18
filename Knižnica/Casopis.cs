using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knižnica
{
    public class Casopis
    {
        public string Tema { get; set; }
        public int Vydanie { get; set; }

        public Casopis(string tema, int vydanie)
        {
            Tema = tema;
            Vydanie = vydanie;
        }

        public void VypisInfo()
        {
            Console.WriteLine("Tema" + Tema + "Vydanie" + Vydanie);
        }
    }
}
