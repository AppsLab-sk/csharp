namespace ProjektKniznica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kniznica kniznica = new Kniznica();

            //1. Sposb
            User admin = new User("Michal", "3300", true);
            kniznica.RegisterUser(admin, admin);

            User user1 = new User("Andrej", "3301", false);
            kniznica.RegisterUser(admin, user1);

            User user2 = new User("Marek", "3302", false);
            kniznica.RegisterUser(admin, user2);

            //2. Sposob
            kniznica.RegisterUser(admin, new User("Olino", "3303", false));
            kniznica.RegisterUser(admin, new User("OlinovoDvojca", "3304", false));

            //Vypise chybu
            kniznica.RegisterUser(user1, new User("Tamtus", "3305", false));

            //Vypise uzivatelov
            kniznica.DisplayUsers();

            //Prida 4 knihy 
            kniznica.PridatKnihu(admin, new Kniha("2038", "Pan Prstenov", "J.R.R. Tolkien", 1950, true));
            kniznica.PridatKnihu(admin, new Kniha("2039", "Zaklinac", "Andrzezej Sapkowski", 1990, true));
            kniznica.PridatKnihu(admin, new Kniha("2040", "Harry Potter", "J.K. Rowling", 1992, true));
            kniznica.PridatKnihu(admin, new Kniha("2041", "Biblia", "Pan Bozko", 0, true));

            //Chyba
            kniznica.PridatKnihu(user2, new Kniha("2042", "Star Wars", "Ujo Ridly Skot", 1975, true));
            kniznica.DisplayBooks();

            //Prida userovi2 knihu
            Kniha najdenaKniha = kniznica.knihy[0];
            kniznica.RentBook(user2, najdenaKniha);

            //Chyba
            Kniha najdenaKniha1 = kniznica.knihy[0];
            kniznica.RentBook(user1, najdenaKniha1);

            //Vyhlada knihu a da ju uzivatelovi podla ID
            Kniha vyhladanKniha = kniznica.knihy.Find(kniha => kniha.idKnihy == "2039");
            kniznica.RentBook(user1, vyhladanKniha);

            //Vyhlada knihu a da ju uzivatelovi podla mena knihy
            Kniha vyhladanaKniha2 = kniznica.knihy.Find(kniha => kniha.nazovKnihy.Contains("Harry"));
            kniznica.RentBook(user2, vyhladanaKniha2);

            //Vrati knihu uzivatela 
            kniznica.ReturnBook(user2, najdenaKniha);

            //Chyba
            kniznica.ReturnBook(admin, najdenaKniha);

            //INSPEKCIA
            kniznica.Inspekcia(admin);
            kniznica.DisplayBooks();
            kniznica.KoniecInspekcie(admin);
            kniznica.DisplayBooks();

            //Chyba
            kniznica.Inspekcia(user1);
            kniznica.KoniecInspekcie(user2);

        }
    }
}