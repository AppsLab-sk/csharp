using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knižnica
{
    public class kniznica
    {
        public List<Kniha> knihas = new List<Kniha>();
        public List<User> users = new List<User>();
        public Dictionary<Kniha, User> zakaznik = new Dictionary<Kniha, User>();

        public void AddKniha(User user, Kniha kniha)
        {
            if (user.isAdmin)
            {
                knihas.Add(kniha);
                Console.WriteLine($"Kniha {kniha.nazov} bola pridana do kniznice");
            }
            else
            {
                Console.WriteLine("Nie ste Admin");
            }
        }
        public void RemoveKniha(User user, Kniha kniha)
        {
            if (user.isAdmin)
            {
                knihas.Remove(kniha);
                Console.WriteLine($"Kniha {kniha.nazov} bola vymazana z kniznice");
            }
            else
            {
                Console.WriteLine("Nie ste Admin");
            }
        }
        public void DisplayKniha()
        {
            Console.WriteLine("Info o knihe");
            foreach (var kniha in knihas)
            {
                kniha.VypisInfo();
            }
        }
        public void DisplayUser()
        {
            Console.WriteLine("Info o knihe");
            foreach (var user in users)
            {
                user.VypisInfo();
            }
        }
        public void RegisterUser(User user, User novyUser)
        {
            if (user.isAdmin)
            {
                users.Add(novyUser);
                Console.WriteLine($"Pouzivatel {novyUser.Meno} bol/a pridany");
            }
            else
            {
                Console.WriteLine("Nie si Admin");
            }
        }
        public void DeleteUser(User user, User novyUser)
        {
            if (novyUser.isAdmin)
            {
                users.Remove(novyUser);
                Console.WriteLine($"Pouzivatel {novyUser.Meno} bol/a odstraneni");
            }
            else
            {
                Console.WriteLine("Nie si Admin");
            }
        }
        public void RentBook(User user, Kniha kniha)
        {
            if (kniha.Dostupna)
            {
                zakaznik.Add(kniha, user);
                kniha.Dostupna = false;
                Console.WriteLine($"Kniha {kniha.nazov} bola vratena pouzivatelovi {user.Meno}. ");

            }
        }
        public void ReturnBook(User user, Kniha kniha)
        {
            if (zakaznik.ContainsKey(kniha) && zakaznik[kniha] == user)
            {
                zakaznik.Remove(kniha);
                kniha.Dostupna = false;
                Console.WriteLine($"Kniha {kniha.nazov} bola vratena pouzivatelom{user.Meno}");
            }
            else
            {
                Console.WriteLine("Kniha nie je dostupna ");
            }
        }
        
    }
}
