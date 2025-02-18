using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    public class Kniha
    {
        public string IdKnihy { get; set; }
        public string Name { get; set; }
        public string Autor { get; set; }
        public int Rok { get; set; }
        public bool JeDostupna { get; set; }

        public Kniha(string idKnihy, string name, string autor, int rok)
        {
            IdKnihy = idKnihy;
            Name = name;
            Autor = autor;
            Rok = rok;
        }

        public void VypisInfo()
        {
            Console.WriteLine($"Id knihy: " + IdKnihy + "Nazov: " + Name + "Autor: " + Autor + "Rok: " + Rok + "Je dostupna: " + JeDostupna);
        }
    }

}
