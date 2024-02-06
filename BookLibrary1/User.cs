using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary
{
    public class User
    {
        public int ID { get; set; }
        public string FullName { get; set; }
        public string City { get; set; }
        public DateTime Birthday { get; set; }
        public List<Book> BorrowedBooks { get; set; } = new List<Book>();
        public Gender Gender { get; set; }
        public User(int iD, string fullName, string city, DateTime birthday,Gender gender)
        {
            ID = iD;
            FullName = fullName;
            City = city;
            Birthday = birthday;           
            Gender = gender;
        }
    }
    public enum Gender
    {
        male,
        female,
        attackhelicoter,
        samsungsmartfridge,
    }
}
