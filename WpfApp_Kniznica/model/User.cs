using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp_Kniznica
{
    public class User
    {
        private static int _nextID = 1;
        public string Meno { get; set; }
        public string Priezvisko { get; set; }
        public string Email { get; set; }
        public int Telc { get; set; }
        public int ID { get; set; }
        public bool IsAdmin { get; set; }

        public User(string meno, string priezvisko, string email, int telc, bool isAdmin)
        {
            Meno = meno;
            Priezvisko = priezvisko;
            Email = email;
            Telc = telc;
            ID = _nextID;
            IsAdmin = isAdmin;
        }

        public void VypisInfo()
        {
            Console.WriteLine("Meno" + Meno + "Priezvisko" + Priezvisko + "Email" + Email + "Telc" + Telc);
        }


    }
}
