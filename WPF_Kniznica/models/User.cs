using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Kniznica
{
    public class User
    {
        public static int _nextId = 1;
        public string Meno { get; set; }
        public string Priezvisko { get; set; }
        public string Email { get; set; }
        public int Telefon { get; set; }
        public int ID { get; set; }

        public User(string meno, string priezvisko, string email, int telefon)
        {
            Meno = meno;
            Priezvisko = priezvisko;
            Email = email;
            Telefon = telefon;
            ID = _nextId++;
        }
    }
}
