using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary
{
    public class Book
    {
        public int ID {  get; set; }
        public string Name {  get; set; }
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
                return $"{Name.PadRight(15, ' ')}{BorrowedBy.FullName.PadRight(15, ' ')}{BorrowedTime.ToString().PadRight(15, ' ')}";
            else
                return $"{Name.PadRight(15, ' ')}";
        }  
    }
    public enum BookGenre
        {
            Scifi,
            Comedy,
            Cartoon,
            Comix   
        }

    public static class EnumExtensions
    {
        public static NameValueBinder ToListItem(this Enum value)
        {
            string description = value.GetDescription();
            return new NameValueBinder(value, description);
        }

        public static string GetDescription(this Enum enumVal)
        {
            var type = enumVal.GetType();
            var memInfo = type.GetMember(enumVal.ToString());
            var attributes = memInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);

            foreach (var attribute in attributes)
            {
                if (attribute.GetType() == typeof(DescriptionAttribute))
                    return (attribute as DescriptionAttribute).Description;
            }

            // No description attribute found, just return the name
            return enumVal.ToString();
        }
    }

    public class NameValueBinder
    {
        public BookGenre Value { get; private set; }
        public string Description { get; private set; }

        public NameValueBinder(Enum value, string description)
        {
            Value = (BookGenre)value;
            Description = description;
        }

        // Override ToString to return the Description
        public override string ToString()
        {
            return Description;
        }
    }

}
