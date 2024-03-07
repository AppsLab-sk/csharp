using BookLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    internal class DataGenerator
    {
        public static List<string> BookNames { get; set; } = new List<string>() { "Harry Potter","Pan prsteňov","Denník odvážneho bojka","Babka Gaunerka","Pempin na hrade" };
        public static List<string> Authors { get; set; } = new List<string>() { "Kuljovský G.", "Čuboň T.", "Bojko S.", "Tupac K.", "Kullac T." };
        public static List<string> FirstNames { get; set; } = new List<string>() { "Pišta","Lojzo","Fero","Jaro","Bohuš" };

        public static List<string> LastNames { get; set; } = new List<string>() { "Mucha","Kohút","Janco","Slepačiar","Medík"};
        public static List<string> Cities { get; set; } = new List<string>() {"TNT","CA","BB","ZA","ZV"};

        public static List<Book> GenerateBooks() 
        {
            var random = new Random();
            var books = new List<Book>();
            for (int i = 0; i < BookNames.Count; i++) 
            { 
                var bookName = BookNames[i];
                var author = Authors[i];
                var releaseDate = new DateTime(random.Next(1900, 2009), random.Next(1, 13), random.Next(1, 28));
                var bookGenre = (BookGenre)Enum.ToObject(typeof(BookGenre), random.Next(0, 5));

                var newBook = new Book(i, bookName, author, releaseDate, bookGenre);
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
        
        
        
        
        
        
        

    
    
    
    
    
    
    
    
    
    

