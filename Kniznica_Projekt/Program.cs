namespace Kniznica_Projekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 sposob ako priadat ludi
          Kniznica kniznica = new Kniznica();

            User admin = new User("Michal", "3300", true);
            kniznica.AddUser(admin, admin);

            User user1 = new User("Andrej", "5745", false);
            kniznica.AddUser(admin, user1);

            User user2 = new User("Marek", "5775", false);
            kniznica.AddUser(admin, user2);

            // 2 sposob ako pridat

            kniznica.AddUser(admin, new User("Olino", "5564", false));
            kniznica.AddUser(admin, new User("Jan", "7564", false));
            kniznica.AddUser(user1, new User("Jan", "7564", false));

            kniznica.Displayuser();

            kniznica.AddBook(admin, new Kniha("2018", "Zaklinac", "Andrej Saptovsky", 1987, false));
            kniznica.AddBook(admin, new Kniha("2019", "Bibleee", "Smusa kovy", 2019, false));
            kniznica.AddBook(admin, new Kniha("2020", "Harry Potter", "J.K. Rowlingova", 1998, true));
            kniznica.AddBook(admin, new Kniha("2021", "1945", "Orvel", 2000, true));
            kniznica.AddBook(admin, new Kniha("2022", "Amazing Spider-Man", "Stan Leee", 1987, false));

            kniznica.Displayknihy();

            Kniha najdiknihu = kniznica.knihy[0];
            kniznica.RentBook(user2, najdiknihu);

            List<Kniha> najdi = kniznica.knihy.Where(kniha => kniha.JeDostupna == true).ToList();
            foreach (Kniha uadj in najdi)
            {
                kniznica.RentBook(admin, uadj);
            }
            


            kniznica.ReturnBook(user2, najdiknihu);


        }
        







    }
}