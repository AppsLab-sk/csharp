using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BookLibrary
{
    public class Book
    {
        private int i;
        private string bookName;
        private BookGenre bookGenre;

        public int ID { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public DateTime ReleaseDate { get; set; }
        public BookGenre Genre { get; set; }

        public bool IsBorrowed { get; set; }
        public DateTime BorrowedTime { get; set; }
        public User BorrowedBy { get; set; }
        public bool IsNew { get; set; }
        public Book(int iD, string name, string author, DateTime releaseDate, BookGenre genre, bool isNew)
        {
            ID = iD;
            Name = name;
            Author = author;
            ReleaseDate = releaseDate;
            Genre = genre;
            IsNew = isNew;
        }

        public Book(int i, string bookName, string author, DateTime releaseDate, BookGenre bookGenre)
        {
            this.i = i;
            this.bookName = bookName;
            Author = author;
            ReleaseDate = releaseDate;
            this.bookGenre = bookGenre;
        }

        public override string? ToString()
        {
            if (IsBorrowed)
            {
                return $"{Name.PadRight(15, ' ')}{BorrowedBy.FullName.PadRight(15, ' ')}{BorrowedTime.ToString().PadRight(15, ' ')}";
            }
            else
            {
                return $"{Name.PadRight(15, ' ')}";
            }
        }
    }
    
public enum BookGenre
    {
        SciFi,
        Comedy,
        Cartoon,
        Comix,
        Fantasy
    }
}
