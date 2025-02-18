using System.Runtime.InteropServices;

namespace ConsoleApp9
{
    class Program
    {
        static void Main()
        {
            Kniznica kniznica = new Kniznica();

            // toto je 1 sposob ako vytvorit uzivatela
            User admin = new User("Michal", "2033", true);
            kniznica.RegisterUser(admin, admin);

            User user1 = new User("Andrej", "2033", false);
            kniznica.RegisterUser(admin, user1);

            User user2 = new User("Marek", "2033", false);
            kniznica.RegisterUser(admin, user2);

            // toto je 2 sposob ako vytvorit uzivatela
            kniznica.RegisterUser(admin, new User("Olino", "2033", false));

            // Vypise "Nie ste admin. Nemozete pridavat userov."
            kniznica.RegisterUser(user1, new User("Matus", "2033", false));

            kniznica.DisplayUsers();

            kniznica.AddKniha(admin, new Kniha("2033", " Harry ", "Autor", 2024));
            kniznica.AddKniha(admin, new Kniha("2034", " Prstenov ", "Autor", 2024));
            kniznica.AddKniha(admin, new Kniha("2035", " Zaklinac ", "Autor", 2024));
            kniznica.AddKniha(admin, new Kniha("2036", " Borderland ", "Autor", 2024));

            //vypise "Nie ste admin. Nemozete pridavat knihy."
            kniznica.AddKniha(user2, new Kniha("2834", "The grey house", "Pertosian", 2024));

            kniznica.DisplayKniha();

            Kniha najdenaKniha = kniznica.Knihy[0];
            kniznica.RentKniha(user2, najdenaKniha);

            Kniha najdenaKniha1 = kniznica.Knihy.Find(kniha => kniha.IdKnihy == "2033");
            kniznica.RentKniha(user1, najdenaKniha1);

            Kniha najdenaKniha2 = kniznica.Knihy.Find(kniha => kniha.Name.Contains("Prstenov"));
            kniznica.ReturnKniha(user1, najdenaKniha2);

            kniznica.ReturnKniha(user1, najdenaKniha1);
            kniznica.ReturnKniha(admin, najdenaKniha2);
        }
    }
}