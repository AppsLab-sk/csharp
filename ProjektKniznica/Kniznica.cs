using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektKniznica
{
    public class Kniznica
    {
        public List<Kniha> knihy { get; set; } = new List<Kniha>();
        public List<User> users = new List<User>();
        public Dictionary<Kniha, User> zakaznikPoziciava = new Dictionary<Kniha, User>();

        public void PridatKnihu(User user, Kniha kniha)
        {
            if (user.isAdmin == true)
            {
                knihy.Add(kniha);
                Console.WriteLine($"Kniha '{kniha.nazovKnihy}' bola pridana do kniznice.");
            }
            else
            {
                Console.WriteLine("CHYBA> Nie ste admin, nemozete pridavat knihy!");
            }
        }

        public void OdstranKnihu(User user, Kniha kniha)
        {
            if (user.isAdmin == true)
            {
                knihy.Remove(kniha);
                Console.WriteLine($"Kniha '{kniha.nazovKnihy}' bola odstranena z kniznice.");
            }
            else
            {
                Console.WriteLine("CHYBA> Nie ste admin, nemozete odstranovat knihy!");
            }
        }

        public void DisplayBooks() 
        {
            Console.WriteLine("\nKnihy v kniznici:");
            foreach (Kniha kniha in knihy)
            {
                kniha.VypisInfo();
            }
        }

        public void DisplayUsers()
        {
            Console.WriteLine("\nUseri v systeme:");
            foreach (User user in users)
            {
                user.VypisInfo();
            }
        }

        public void RegisterUser(User admin, User novyUser)
        {
            if (admin.isAdmin)
            {
                users.Add(novyUser);
                Console.WriteLine($"{novyUser.meno} bol/a pridany/a do zoznamu uzivatelov.");
            }
            else
            {
                Console.WriteLine("CHYBA> Nie ste admin, nemozete pridavat uzivatelov!");
            }    
        }
   
        public void DeleteUser(User admin, User novyUser)
        {
            if (admin.isAdmin)
            {
                users.Remove(novyUser);
                Console.WriteLine($"{novyUser.meno} bol/a odstraneny/a zo zoznamu uzivatelov.");
            }
            else
            {
                Console.WriteLine("CHYBA> Nie ste admin, nemozete odstranovat uzivatelov!");
            }
        }

        public void RentBook(User user, Kniha kniha)
        {
            if (kniha.jeDostupna)
            {
                zakaznikPoziciava.Add(kniha, user);
                kniha.jeDostupna = false;
                Console.WriteLine($"{kniha.nazovKnihy} bola prepozicana uzivatelovi {user.meno}");
            }
            else
            {
                Console.WriteLine("Kniha aktualne nie je dostupna.");
            }
        }

        public void ReturnBook(User user, Kniha kniha)
        {
            if (zakaznikPoziciava.ContainsKey(kniha) && zakaznikPoziciava[kniha] == user)
            {
                zakaznikPoziciava.Remove(kniha);
                kniha.jeDostupna = true;
                Console.WriteLine($"{kniha.nazovKnihy} bola vratena uzivatelom {user.meno}");
            }
            else
            {
                Console.WriteLine("Kniha nie je dostupna.");
            }
        }

        public void Inspekcia(User user)
        {
            if (user.isAdmin)
            {
                foreach(Kniha kniha1 in knihy)
                {
                    kniha1.jeDostupna = false;
                    Console.WriteLine($"Kniha '{kniha1.nazovKnihy}' bola znepristupnena.");
                }
                Console.WriteLine("\nKnihy boli znepristupnene.");
            }
            else
            {
                Console.WriteLine("CHYBA> Nie ste admin, nemozete vykonat danu akciu!");
            }
        }

        public void KoniecInspekcie(User user)
        {
            if (user.isAdmin)
            {
                foreach (Kniha kniha1 in knihy)
                {
                    kniha1.jeDostupna = true;
                    Console.WriteLine($"Kniha '{kniha1.nazovKnihy}' bola spristupnena.");
                }
                Console.WriteLine("\nKnihy boli spristupnene.");
            }
            else
            {
                Console.WriteLine("CHYBA> Nie ste admin, nemozete vykonat danu akciu!");
            }
        }
    }
}
