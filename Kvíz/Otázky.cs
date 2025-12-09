using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Kvíz
{
    public class Otázky
    {
        private const string otazka = "\\\\fs1\\Data_studenti$\\2025\\cvengrosm25\\Desktop\\._\\";
        string[] otazky = { "Ktoré zviera je najrýchlejšie na súši?\n a) Gepard  \n b) Lev \n c) Puma", "Čo je hlavné mesto Francúzska? \n a) Madrid \n b) Paríž \n c) Berlín", "Ktorá planéta je najbližšie k Slnku? \n a) Merkúr \n  b) Venuša \n  c) Zem" };



        public void Otazka()
        {
            Console.WriteLine(otazky[0]);

            List<string> alphabet = new List<string>();
            string vstup = Console.ReadLine();
            string answer = ;



        }

    }
}

