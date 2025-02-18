namespace Knižnica
{
    public class Program
    {
        static void Main(string[] args)
        {
            kniznica kniznica = new kniznica();
            User admin =new User("Michal", "3300", true);
            kniznica.RegisterUser(admin, admin);
            User user1 = new User("Andrej", "3301", false);
            kniznica.RegisterUser(admin, user1);
            User user2 = new User("Marek", "3302", false);
            kniznica.RegisterUser(admin, user2);

            kniznica.RegisterUser(admin, new User("Oliver", "3303", false));
            kniznica.RegisterUser(admin, new User("Matus", "3304", false));

            kniznica.DisplayUser();

            kniznica.AddKniha(admin, new Kniha("2031", "Zaklinac", "Sap..", 2024));
            kniznica.AddKniha(admin, new Kniha("2032", "Harry Potter", "Row..", 2021));
            kniznica.AddKniha(admin, new Kniha("2033", "Pan prstenov", "Talk..", 2023));

            kniznica.DisplayKniha();

            Kniha najdenaKniha = kniznica.knihas[0];
            kniznica.RentBook(user2, najdenaKniha);

            Kniha najdenaKniha1 = kniznica.knihas.Find(kniha => kniha.idKnihy == "2033");
            kniznica.RentBook(user1, najdenaKniha1);

            Kniha najdenaKniha2 = kniznica.knihas.Find(kniha => kniha.nazov.Contains("Harry"));
            kniznica.RentBook(user1, najdenaKniha2);

            kniznica.ReturnBook(user1, najdenaKniha1);
            kniznica.ReturnBook(user2, najdenaKniha2);

            var listDostupnychknih = kniznica.knihas.Where(book => book.Dostupna is true).ToList();
            foreach (var b in listDostupnychknih)
            {
                kniznica.RentBook(admin, b);
            }
        }
    }
}