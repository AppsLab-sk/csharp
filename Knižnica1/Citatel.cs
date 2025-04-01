using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knižnica1
{
    class Citatel
    {
        
        private static int nextID = 1;
        public int ID { get; set; }
        public string Meno { get; set; }
        public string Priezvisko { get; set; }
        public string Email { get; set; }
        public string Telcislo { get; set; }


        public Citatel(string meno, string priezvisko, string email, string telcislo)
        {
            ID = nextID;
            Meno = meno;
            Priezvisko = priezvisko;
            Email = email;
            Telcislo = telcislo;
        }


        public override string ToString()
        {
            return $"ID: {ID} | {Meno} {Priezvisko}, Email: {Email}, Telefonne cislo: {Telcislo}";
        }
    }
}
