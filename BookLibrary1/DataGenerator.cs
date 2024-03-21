    using System.Globalization;

namespace BookLibrary
{
    public class DataGenerator
    {
        public static List<string> BookNames { get; set; } = new List<string>() { "Promile Tour", "Katechezy Pre Kazdeho", "Identita Muža", "Dugel a chrup","Sáčkove fitness tipy a triky" };
        public static List<string> Authors { get; set; } = new List<string>() { "Milan Nevedal", "Miloš Gregor II.", "Pišta Vydra", "Jozef Novák", "Dano Drevo" };
        public static List<string> FirstNames { get; set; } = new List<string>() { "Elias", "Izidor", "Benadikt", "Hubert", "Ambróz" };
        public static List<string> LastNames { get; set; } = new List<string>() { "Forgáč", "Ďurkovič", "Čapka", "Dubovský", "Dočelomanský" };
        public static List<string> Cities { get; set; } = new List<string>() { "Klokočov", "Humenné", "Ružomberok", "Prievidza", "Pezinok" };

        public static List<Book> GenerateBooks()
        {
            var random = new Random();
            var books = new List<Book>();
            for (int i = 0; i < BookNames.Count; i++)
            {
                var bookName = BookNames[i];
                var author = Authors[i];
                var releaseDate = new DateTime(random.Next(1900,2000), random.Next(1, 13), random.Next(1, 20));
                var bookGenre = (BookGenre)Enum.ToObject(typeof(BookGenre), random.Next(0, 5));

                var newBook = new Book (i, bookName, author, releaseDate, bookGenre);
                books.Add(newBook);
            }
            return books;
        }
        public static List<User> GenerateUsers()
        {
            var random = new Random();
            var users = new List<User>();

            for (int i = 0; i < BookNames.Count; i++)
            {
                var firstName = FirstNames[random.Next(0, FirstNames.Count)];
                var lastName = LastNames[random.Next(0, LastNames.Count)];
                var city = Cities[i];
                var birthDay = new DateTime(random.Next(1980, 2020), random.Next(1, 13), random.Next(1, 28));
                var gender = (Gender)Enum.ToObject(typeof(Gender), random.Next(0, 2));

                var newUser = new User(i, firstName + " " + lastName, city, birthDay, gender);
                users.Add(newUser);
            }
            return users;
        }
    }
}