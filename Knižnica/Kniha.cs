using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knižnica
{
    public class Kniha
    {
        public string nazov { get; set; }
        public string autor { get; set; }
        public int rok { get; set; }
        public string idKnihy { get; set; }
        public bool Dostupna { get; set; }

        public Kniha( string idKnihy, string nazov, string autor, int rok )
        {
            this.nazov = nazov;
            this.autor = autor;
            this.rok = rok;
            this.idKnihy = idKnihy;
            Dostupna = true;
        }

        public void VypisInfo()
        {
            Console.WriteLine("Nazov" + nazov + "Autor" + autor + "Rok" + rok + "idKnihy" + idKnihy );
        }

        public static List<Kniha> Where(bool v)
        {
            throw new NotImplementedException();
        }
    }

}
