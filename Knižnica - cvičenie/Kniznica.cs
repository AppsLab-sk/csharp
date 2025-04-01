using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace Knižnica___cvičenie
{
    internal class Kniznica
    {
        public List<Kniha> knihy { get; set; }  = new List<Kniha>();
        public List<User> users = new List<User>();
        public Dictionary<Kniha , User> zakazikPoziciava = new Dictionary<Kniha, User>();


        public void AddBook(User user, Kniha kniha)
        {
            if (user.IsAdmin)
            {
                knihy.Add(kniha);
                Console.WriteLine($" Kniha {kniha.Nazov} bola pridana do kniznice.");
            }
            else
            {
                Console.WriteLine(" Nie ste admin. Nemozete pridavat knihy. ");
            }
        }


        public void RemoveBook(User user, Kniha kniha)
        {
            if (user.IsAdmin) 
            {
                knihy.Remove(kniha);
                Console.WriteLine($" Kniha {kniha.Nazov} bola vymazana z kniznice. ");
            }
            else
            {
                Console.WriteLine(" Nie ste admin. Nemozete vymazavat knihy. ");
            }
        }

        public void DisplayKnihy()
        {
            Console.WriteLine(" Knihy v kniznici: ");
            foreach (var kniha in knihy) 
            {
                kniha.VypisInfo();
            }
        }

        public void DisplayUsers()
        {
            Console.WriteLine(" Pouzivatelia v systeme: ");
            foreach (var user in users)
            {
                user.VypisInfo();
            }    
        }

        public void RegisterUser(User admin, User novyUser)
        {
           if (admin.IsAdmin)
            {
                users.Add(novyUser);
                Console.WriteLine($" User {novyUser.Meno} bol pridany. ");
            }
           else
            {
                Console.WriteLine(" Nie si admin. Nemozes pridat usera. ");
            }
        }

        public void DeleteUser (User admin, User novyUser)
        {
            if (admin.IsAdmin)
            {
                users.Remove(novyUser);
                Console.WriteLine($" User {novyUser.Meno} bol odstraneny. ");
            }
            else
            {
                Console.WriteLine(" Nie si admin. Nemozes odobrat usera ");
            }
        }

        public void RentBook(User user, Kniha kniha)
        {
            if (kniha.JeDostupna)
            {
                zakazikPoziciava.Add(kniha, user);
                kniha.JeDostupna = false;
                Console.WriteLine($"Kniha {kniha.Nazov} bola pozicana pouzivatelovi {user.Meno}.");
            }
            else
            {
                Console.WriteLine("Kniha nie je dostupna");
            }
        }

        public void ReturnBook(User user, Kniha kniha)
        {
            if (zakazikPoziciava.ContainsKey(kniha) && zakazikPoziciava[kniha] == user)
            {
                zakazikPoziciava.Remove(kniha);
                kniha.JeDostupna = false;
                Console.WriteLine($"Kniha {kniha.Nazov} bola vratena pouzivatelom {user.Meno}.");
            }
            else
            {
                Console.WriteLine("Kniha nie je dostupna alebo tento zakaznik nepoziciaval tu knihu.");
            }
        }
    }
}
