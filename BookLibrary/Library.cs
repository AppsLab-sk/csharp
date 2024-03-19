using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary
{

    public class Library
    {
        private static Library instance;
        private static readonly object padlock = new object();
        public static Library Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new Library();
                    }
                    return instance;
                }
            }
        }

        public List<Book> Books { get; set; }
        public List<User> Users { get; set; }

        public Library()
        {
            Books = DataGenerator.GenerateBooks();
            Users = DataGenerator.GenerateUsers();
        }

        public bool BorrowBook(Book book, User user, int BorrowedTime)
        {
            if (book.IsBorrowed)
                return false;

            user.BorrowedBooks.Add(book);
            book.IsBorrowed = true;
            book.BorrowedBy = user;
            book.BorrowedTime = DateTime.Now.AddDays(BorrowedTime);

            return true;
        }



    }
}
