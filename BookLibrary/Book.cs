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
        
        public Book(int iD, string name, string author, DateTime releaseDate, BookGenre genre)
        {
            ID = iD;
            Name = name;
            Author = author;
            ReleaseDate = releaseDate;
            Genre = genre;
            
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
