using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary
{
    public class Book
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime ReleaseDate { get; set; }
        public BookGenre Genre { get; set; }
        public bool IsBorrowed { get; set; }
        public DateTime BorrowedTime { get; set; }
        public User BorrowedBy { get; set; }

        public Book(int iD, string title, string author, DateTime releaseDate, BookGenre genre)
        {
            ID = iD;
            Title = title;
            Author = author;
            ReleaseDate = releaseDate;
            Genre = genre;

        }
        public override string? ToString()
        {
            if (IsBorrowed)

                return $"{Title.PadRight(15, ' ')}{BorrowedBy.FullName.PadRight(15, ' ')}{BorrowedTime.ToString().PadRight(15, ' ')}";
            else
                return $"{Title.PadRight(15, ' ')}";
        }
    }
    public enum BookGenre
    { 
        Scifi,
        Comedy,
        Cartoon,
        Comix
    }


}
