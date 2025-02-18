using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kniznica
{
    internal class Pouzivatel
    {
        private static int _nextID = 1; //priklad pre automaticke generovanie ID
        public int ID { get; private set; }
        public string Meno { get; set; }
        public string Priezvisko { get; set; }
        public string Email { get; set; }
        public int Telefon { get; set; }

        public Pouzivatel(int iD, string meno, string priezvisko, string email, int telefon)
        {
            ID = iD;
            Meno = meno;
            Priezvisko = priezvisko;
            Email = email;
            Telefon = telefon;
        }

        public override string ToString()
        {
            return $"ID: {ID} | {Meno} {Priezvisko}, Email: {Email}, Telefon: {Telefon}";
        }
    }
}
