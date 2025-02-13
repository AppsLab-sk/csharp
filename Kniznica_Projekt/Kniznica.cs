using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kniznica_Projekt
{
    internal class Kniznica
    {
        public List<Kniha> knihy { get; set; } = new List<Kniha>();
        public List<User> users { get; set; } = new List<User>();    
        public Dictionary<Kniha, User> ZakaznikPoziciava { get; set; }  = new Dictionary<Kniha, User>();

        public void AddBook(User user, Kniha book) 
        {
            if (user.IsAdmin)
            {
                knihy.Add(book);
                Console.WriteLine($"Kniha {book.Nazov} bola pridana");
            }
            else 
            {
                Console.WriteLine($"Nie si Admin nesmies pridat knihu");
            
            }       
        }
        public void RemoveBook(User user, Kniha book)
        {
            if (user.IsAdmin)
            {
                knihy.Remove(book);
                Console.WriteLine($"Kniha {book.Nazov} bola odstranena");
            }
            else
            {
                Console.WriteLine($"Nie si Admin nesmies odstranit knihu");

            }
        }
        public void Displayknihy() 
        {
            Console.WriteLine("Knihy v systeme");
            foreach (var kniha in knihy)
            {
                kniha.VypisInfo();
            }
             
        }
        public void Displayuser()
        {
            Console.WriteLine("Uzivatelia v systeme");
            foreach (var usero in users)
            {
                usero.VypisInfo();
            }

        }
        public void AddUser(User admin, User user) 
        {
            if (admin.IsAdmin)
            {
                users.Add(user);
                Console.WriteLine($"Uzivatel {user.Meno} pridani ");
            }
            else 
            {
                Console.WriteLine($"Nesmies pridat {user.Meno}");
            }
               
        }
        public void RemoveUser(User admin, User user)
        {
            if (admin.IsAdmin)
            {
                users.Remove(user);
                Console.WriteLine($"Uzivatel {user.Meno} odstraneni ");
            }
            else
            {
                Console.WriteLine($"Nesmies odstranit {user.Meno}");

            }
        }
        public void RentBook(User user, Kniha kniha) 
        {
            if (kniha.JeDostupna)
            {
                ZakaznikPoziciava.Add(kniha, user);
                kniha.JeDostupna = false;
                Console.WriteLine($"kniha: {kniha.Nazov} bola pozicana pouzivatelom {user.Meno}");

            }
            else 
            { 
             Console.WriteLine($"Kniha nieje dostupna");
            
            }       
        }
        public void ReturnBook(User user, Kniha kniha)
        {
            if (ZakaznikPoziciava.ContainsKey(kniha) && ZakaznikPoziciava[kniha] == user)
            {
                ZakaznikPoziciava.Remove(kniha);
                kniha.JeDostupna = false;
                Console.WriteLine($"kniha: {kniha.Nazov} bola vratena pouzivatelom {user.Meno}");

            }
            else
            {
                Console.WriteLine($"Kniha nieje dostupna");

            }
        }
    }
}
