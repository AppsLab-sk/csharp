namespace Knižnica___cvičenie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kniznica kniznica = new Kniznica();
            // 1. sposob ako vytvorit uzivatela
            User admin = new User("Michal", "3300", true);
            kniznica.RegisterUser(admin, admin);
            
            User user1 = new User("Andrej", "3301", false);
            kniznica.RegisterUser(admin, user1);

            User user2 = new User("Marek", "3302", false);
            kniznica.RegisterUser(admin, user2);

            //2. sposob ako vytvorit uzivatela
            kniznica.RegisterUser(admin, new User("Oliver", "3303", false));

            //Vypise "Nie ste admin. Nemozete pridavat userov."
            kniznica.RegisterUser(user1, new User("Matus", "3304", false));

            kniznica.DisplayUsers();




            kniznica.AddBook(admin, new Kniha("2038", "nazov", "Autor", 2024, true));
            kniznica.AddBook(admin, new Kniha("2031", "Zaklinac", "Sap.....", 2024, true));
            kniznica.AddBook(admin, new Kniha("2032", "Pan prstenov", "Tolkien", 2024, true));
            kniznica.AddBook(admin, new Kniha("2033", "Harry Potter", "Row.....", 2024, true));


            // vypise "Nie ste admin. Nemozete pridavat knihy."
            kniznica.AddBook(user2, new Kniha("2034", "The gray house", "Petrosian", 2024, true));

            kniznica.DisplayKnihy();

            // Pozicanie knihy userovi 2 
            Kniha najdenaKniha = kniznica.knihy[0];
            kniznica.RentBook(user2, najdenaKniha);

            // Pozicanie knihy userovi 1 podla IDcka
            Kniha najdenaKniha1 = kniznica.knihy.Find(kniha => kniha.IdKnihy == "2033");
            kniznica.RentBook(user1, najdenaKniha1);

            // Pozcicanie knihy userovi 1 ktora obsahuje slovo Pan
            Kniha najdenaKniha2 = kniznica.knihy.Find(kniha => kniha.Nazov.Contains ("Pan"));
            kniznica.RentBook(user1, najdenaKniha2);

            List<Kniha> dostupneKnihy = kniznica.knihy.Where(kniha => kniha.JeDostupna == true).ToList();
            foreach (var kniha in dostupneKnihy)
            {
                kniznica.RentBook(admin, kniha);
            }

            // Vratenie knihy od usera 1
            kniznica.ReturnBook(user1, najdenaKniha1);

            
            kniznica.ReturnBook(admin, najdenaKniha2);
        }
    }
}