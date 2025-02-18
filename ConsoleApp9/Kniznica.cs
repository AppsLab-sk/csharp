using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    public class Kniznica
    {
        public List<Kniha> Knihy { get; set; } = new List<Kniha>();
        public List<User> Users { get; set; } = new List<User>();
        public Dictionary<Kniha, User> zakaznikPozicava { get; set; } = new Dictionary<Kniha, User>();


        public void AddKniha(User user, Kniha kniha)
        {
            if (user.IsAdmin)
            {
                Knihy.Add(kniha);
                Console.WriteLine($"Kniha" + kniha.Name + "bola pridana do kniznice.");
            }
            else
            {
                Console.WriteLine("Nie ste admin. Nemozete pridavat knihy.");
            }
        }

        public void RemoveKniha(User user, Kniha kniha)
        {
            if(user.IsAdmin)
            {
                Knihy.Remove(kniha);
                Console.WriteLine($"Kniha" + kniha.Name + "bola vymazana z kniznice.");
            }
            else
            {
                Console.WriteLine("Nie ste admin. Nemozete vymazavat knihy.");
            }
        }

        public void DisplayKniha() 
        {
            Console.WriteLine("Knihy v kniznici:");
            foreach (var kniha in Knihy)
            {
                kniha.VypisInfo();
            }
        }

        public void DisplayUsers()
        {
            Console.WriteLine("Pouzivatelia v systeme:");
            foreach (var user in Users)
            {
                user.VypisInfo();
            }
        }

        public void RegisterUser(User admin, User novyUser)
        {
            if(admin.IsAdmin)
            {
                Users.Add(novyUser);
                Console.WriteLine($"User: " + novyUser.Name + "bol pridany.");
            }
            else
            {
                Console.WriteLine("Nie ste admin. Nemozete pridavat pouzivatelov.");
            }
        }

        public void DeleteUser(User admin, User novyUser) 
        {
            if (admin.IsAdmin)
            {
                Users.Remove(novyUser);
                Console.WriteLine($"User: " + novyUser.Name + "bol odstraneny.");
            }
            else
            {
                Console.WriteLine("Nie ste admin. Nemozete odstranit pouzivatelov.");
            }
        }

        public void RentKniha(User user, Kniha kniha)
        {
            if(kniha.JeDostupna)
            {
                zakaznikPozicava.Add(kniha, user);
                kniha.JeDostupna = false;
                Console.WriteLine($"Kniha " + kniha.Name + "bola pouzivatelovi " + user.Name);
            }
            else
            {
                Console.WriteLine("Kniha nieje dostupna.");
            }
        }

        public void ReturnKniha(User user, Kniha kniha)
        {
            if(zakaznikPozicava.ContainsKey(kniha) && zakaznikPozicava[kniha] == user)
            {
                zakaznikPozicava.Remove(kniha);
                kniha.JeDostupna = false;
                Console.WriteLine($"Kniha " + kniha.Name + "bola vratena pouzivatelom " + user.Name);
            }
            else
            {
                Console.WriteLine("Kniha nieje dostupna.");
            }
        }


    }
}
