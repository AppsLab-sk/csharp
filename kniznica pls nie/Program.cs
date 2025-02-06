using System.Runtime.InteropServices;

namespace kniznica_pls_nie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Prvy sposob ako vytvorit uzivatelov
            Kniznica kniznica = new Kniznica();

            User admin = new User("Michal", "3300", true);
            kniznica.RegisterUser(admin, admin);

            User user1 = new User("Andrej", "6969", false);
            kniznica.RegisterUser(admin, user1);

            User user2 = new User("Marek", "1965", false);
            kniznica.RegisterUser(admin, user2);

            //2. sposob ako vytvorit uzivatelov
            kniznica.RegisterUser(admin, new User("Olino", "1586", false));

            //Niesi admin cize nn
            //kniznica.RegisterUser(user1, new User("Daryl", "7854", false));

            kniznica.DisplayUser();


            kniznica.Addbook(admin, new Kniha("2918", "zaklinc", "idk..", 2024, true));

            kniznica.Addbook(admin, new Kniha("2019", "Nazovsd", "Autorsd", 2024, true));

            kniznica.Addbook(admin, new Kniha("2018", "Nazovg", "Autors", 2024, true));

            kniznica.Addbook(admin, new Kniha("2458", "Harry Potter", "How...", 2024, true));

            kniznica.Addbook(user2, new Kniha("2618", "biblija", "boh ig", 2024, true));

            kniznica.Displayknihy();

            Kniha najdenakniha = kniznica.knihy[0];
            kniznica.PozicanieKnihy(user2, najdenakniha);

            Kniha najdenakniha2 = kniznica.knihy.Find(kniha => kniha.Nazov.Contains("Nazovg"));
            kniznica.PozicanieKnihy(user1, najdenakniha2);

            Kniha najdenakniha1 = kniznica.knihy.Find(kniha => kniha.Nazov.Contains("Harry"));

            List<Kniha> dostupneKnihy = kniznica.knihy.Where(kniha => kniha.JeDostupna == true).ToList();
            foreach (var kniha in dostupneKnihy)
            {
                kniznica.PozicanieKnihy(admin, kniha);
            }

            kniznica.PozicanieKnihy(user1,najdenakniha1);

            kniznica.VratitKnihu(user2, najdenakniha);

            kniznica.VratitKnihu(admin, najdenakniha);
        }
    }
}