using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace kniznica_pls_nie
{
    internal class Kniznica
    {
        public List<Kniha> knihy { get; set; } = new List<Kniha>();
        public List<User> users = new List<User>();
        public Dictionary<Kniha, User> ZakaznikPoziciava = new Dictionary<Kniha, User>();

        public void Addbook(User user, Kniha kniha)
        {
            if (user.IsAdmin)
            {
                knihy.Add(kniha);
                Console.WriteLine($"Kniha {kniha.Nazov} bola pridana");
            }
            else
            {
                Console.WriteLine($"Nieste admin. Nemozete pridavat knihy.");
            }
        }
        public void OdstranKnihu(User user, Kniha kniha)
        {
            if (user.IsAdmin)
            {
                knihy.Remove(kniha);
                Console.WriteLine($"Kniha {kniha.Nazov} bola odstranena");

            }
            else
            {
                Console.WriteLine($"Nieste admin. Nemozete odstranit knihy.");
            }
        }

        public void Displayknihy()
        {
            foreach (var kniha in knihy)
            {
                kniha.VipisInfo();
            }
        }
        public void DisplayUser()
        {
            foreach (var user in users)
            {
                user.VipisInfo();
            }
        }
        public void RegisterUser(User admin, User novyuser)
        {
            if (admin.IsAdmin)
            {
                users.Add(novyuser);
                Console.WriteLine($" Pouzivatel {novyuser.Meno}");
            }
            else
            {
                Console.WriteLine($" Niesi admin cize nemozes pridat usera.");
            }
        }
        public void UnregisterUser(User admin, User novyuser)
        {
            if (admin.IsAdmin)
            {
                users.Remove(novyuser);
            }
            else 
            {
                Console.WriteLine($" Niesi admin cize nemozes odobrat usera.");
             }
        }
        public void PozicanieKnihy(User user, Kniha kniha)
        {
            if (kniha.JeDostupna)
            {
                ZakaznikPoziciava.Add(kniha,user);
                kniha.JeDostupna = false;
                Console.WriteLine($" Kniha {kniha.Nazov} bola pozicana {user.Meno}");
            }
            else
            {
                Console.WriteLine($" Kniha nieje dostupna");
            }
        }
        public void VratitKnihu(User user, Kniha kniha)
        {
            if (ZakaznikPoziciava.ContainsKey(kniha) && ZakaznikPoziciava[kniha] == user)
            {
                ZakaznikPoziciava.Remove(kniha);
                kniha.JeDostupna = true;
                Console.WriteLine($" Kniha {kniha.Nazov} bola vratena {user.Meno}");
            }
            else
            {
                Console.WriteLine($" Kniha nie je dostupna");
            }
        }
    }
}
