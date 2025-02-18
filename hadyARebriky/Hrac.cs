using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hadyARebriky
{
    public class Hrac
    {
        public string Meno { get; set; }
        public int Pozicia { get; set; }
        public Kocka Kocka { get; set; }


        public Hrac(string meno)
        {
            Meno = meno;
            Pozicia = 0;
        }


        public void Pohyb (int hodnotaKocky)
        {
            int hod = Kocka.Hod(); 
            Pozicia += hod;       
            Console.WriteLine($"{Meno} je teraz na pozícii: {Pozicia}");
        }
        

    }

}