using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kniznica
{
    public class Kniha
    {
        public string IdKnihy;
        public string nazov;
        public string autor;
        public int rok;
        public bool jeDostupna;


        public string idKnihy 
        { 
            get { return IdKnihy;}
            set { IdKnihy = value;}
        }
        public string Nazov
        {
            get { return nazov; }
            set { nazov = value; }
        }
        public string Autor
        {
            get { return autor; }
            set { autor = value; }
        }
        public int Rok
        {
            get { return rok; }
            set { rok = value; }
        }
        public bool JeDostupna
        {
            get { return jeDostupna; }
            set { jeDostupna = value; }
        }

        public Kniha(string idKnihy, string nazov, string autor, int rok, bool jeDostupna)
        {
            IdKnihy = idKnihy;
            this.nazov = nazov;
            this.autor = autor;
            this.rok = rok;
            this.jeDostupna = jeDostupna;
        }

        public void VypisInfo()
        {
            Console.WriteLine($"ID: {idKnihy}, Nazov: {Nazov}, Autor: {Autor}, Rok vydania: {Rok}, Je dostupna: {JeDostupna}");
        }
    }


}
