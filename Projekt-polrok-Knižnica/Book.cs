using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_polrok_Knižnica
{
    public class Book
    {
        public int ID { get; set; }
        public string NazovKnihy { get; set; }
        public string Autor { get; set; }
        public int Rok { get; set; }
        public string Zaner { get; set; }

        public Book(int iD, string nazovKnihy, string autor, int rok, string zaner)
        {
            ID = iD;
            NazovKnihy = nazovKnihy;
            Autor = autor;
            Rok = rok;
            Zaner = zaner;
        }

       
        
        }
    }


