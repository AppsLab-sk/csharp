using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace hrac
{
    public class hrac
    {
        public string Meno { get; set; }
        public int Skore { get; set; }

        public hrac(string meno)
        {
            Meno = meno;

        }

       

        public void Kocka(hrac hrac)
        {
            Random random = new Random();
            int randomNumer = random.Next(1, 7);
            if (randomNumer <= this.Skore)
            {
                Console.WriteLine(this.Meno + "hodil ");
            }

        }

    }
}
