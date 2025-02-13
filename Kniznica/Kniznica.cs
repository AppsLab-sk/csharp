using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kniznica
{
    public class Kniznica
    {
        public List<Kniha> knihy { get; set; } = new List<Kniha>();
        public List<User> users = new List<User>();
        public Dictionary<Kniha, User> zakaznikPoziciava = new Dictionary<Kniha, User>();

        public void PridatKnihu(User user, Kniha kniha)
        {
            if(user.isAdmin)
            {
                knihy.Add(kniha);
                Console.WriteLine($"Kniha '{kniha.nazov}' bola pridana do knznice.");
            }
            else
            {
                Console.WriteLine("Nie si admin. Nemozes pridavat knihy");
            }
        }

        public void OdstranovanieKnihy(User user, Kniha kniha) 
        { 
            if(user.isAdmin) 
            { 
                knihy.Remove(kniha);
                Console.WriteLine($"Kniha '{kniha.nazov}' bola odstranena z kniznoice");

            }
            else
            {
                Console.WriteLine("Nie si admin. Nemozes pridavat knihy");
            }
        }

        public void DisplayBooks()
        {
            foreach (Kniha kniha in knihy)
            {
                kniha.VypisInfo();
            }
        }
        public void DisplayUser()
        {
            foreach (User user in users)
            {
                user.VypisInfo();
            }
        }

        public void RegisterUsers(User admin, User novyUser)
        {
            if (admin.isAdmin)
            {
                users.Add(novyUser);
                Console.WriteLine($"{novyUser.Meno} bol pridany/a do kniznicneho zoznamu.");
            }
            else
            {
                Console.WriteLine("CHYBA: Nie ste admin!!!");
            }
        }
        public void DeleteUsers(User admin, User novyUser)
        {
            if (admin.isAdmin)
            {
                users.Remove(novyUser);
                Console.WriteLine($"{novyUser.Meno} bol odstraneny/a z kniznicneho zoznamu.");
            }
            else
            {
                Console.WriteLine("CHYBA: Nie ste admin!!!");
            }
        }

        public void RentBook (User user, Kniha kniha)
        {
            if (kniha.jeDostupna)
            {
                zakaznikPoziciava.Add(kniha, user);
                kniha.jeDostupna = false;
                Console.WriteLine($"{kniha.nazov} bola prepozicana!!!");
            }
            else
            {
                Console.WriteLine("Kniha nie je dostupna!!!!!");
            }
        }

        public void ReturnBook(User user, Kniha kniha)
        {
            if(zakaznikPoziciava.ContainsKey(kniha) && zakaznikPoziciava[kniha] == user)
            {
                zakaznikPoziciava.Remove(kniha);
                kniha.jeDostupna=true;
                Console.WriteLine($"{kniha.nazov} bola vratena uzivatelom {user.Meno}");
            }
            else
            {
                Console.WriteLine("Kniha nie je dostupna");
            }
        }

        public void Inspekcia(User user, Kniha kniha)
        {
            if(user.isAdmin)
            {
                foreach(Kniha kniha1 in knihy)
                {
                    kniha1.jeDostupna = false;
                    Console.WriteLine($"Kniha {kniha.nazov} je znapristupnena.");
                }
                Console.WriteLine("Knihy su zablokovane");
            }
            else
            {
                Console.WriteLine("Nemate pristup ku kniham");
            }
        }
    }
}