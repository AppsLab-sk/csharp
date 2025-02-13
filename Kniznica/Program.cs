namespace Kniznica
{
    public class Program
    {
        static void Main(string[] args)
        {
            Kniznica kniznica = new Kniznica();

            //1 sposob
            User admin = new User("Michal", "3300", true);
            kniznica.RegisterUsers(admin, admin);

            User user1 = new User("Andrej", "3301", false);
            kniznica.RegisterUsers(admin, user1);

            User user2 = new User("Marek", "3302", false);
            kniznica.RegisterUsers(admin, user2);

            //2 sposob
            kniznica.RegisterUsers(admin, new User("Olino", "3303", false));
            kniznica.RegisterUsers(admin, new User("OlinovoDvojca", "3304", false));
            kniznica.RegisterUsers(admin, new User("TamtusEkeb", "3305", false));

            kniznica.RegisterUsers(user1, new User("TamtusEkeb", "3305", false));

            kniznica.DisplayUser();

            kniznica.PridatKnihu(admin, new Kniha("2038", "Nazov", "Autor", 2026, true));
            kniznica.PridatKnihu(admin, new Kniha("2039", "Zaklinac", "Andrzej Sapkowsky", 1990, true));
            kniznica.PridatKnihu(admin, new Kniha("2040", "Ujo Potter", "J.R.R.Rowling", 1992, true));
            kniznica.PridatKnihu(admin, new Kniha("2041", "Biblia", "Bozko pan", 0, true));
            kniznica.PridatKnihu(admin, new Kniha("2042", "Pan Prstenov", "J.R.R. Tolkien", 1992, true));

            kniznica.PridatKnihu(user2, new Kniha("2038", "Nazov", "Autor", 2026, true));

            kniznica.DisplayBooks();

            Kniha najdenaKniha = kniznica.knihy[0];
            kniznica.RentBook(user2, najdenaKniha);

            Kniha najdenaKniha1 = kniznica.knihy[0];
            kniznica.RentBook(user1, najdenaKniha1);

            //Vyhlada knihu a da ju uzivatelovi
            Kniha vyhladanieKnihy1 = kniznica.knihy.Find(kniha => kniha.idKnihy == "2023");
            kniznica.RentBook(user1, vyhladanieKnihy1);

            Kniha vyhladanieKnihy2 = kniznica.knihy.Find(kniha => kniha.nazov == "Potter");
            kniznica.RentBook(user2, vyhladanieKnihy1);

            kniznica.Inspekcia(admin, vyhladanieKnihy2);

            kniznica.Inspekcia(user1, najdenaKniha1);
        }
    }
}