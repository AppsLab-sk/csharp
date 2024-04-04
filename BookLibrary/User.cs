using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BookLibrary
{
    public class User
    {
        public int ID { get; set; }
        public string FullName { get; set; }
        public string City { get; set; }
        public DateTime BirthDay { get; set; }
        public List<Book> BorrowedBooks { get; set; } = new List<Book>();
        public Gender Gender { get; set; }
        public object Id { get; }

        public User(int iD, string fullname, string city, DateTime birthDay, Gender gender)
        {
            ID = iD;
            FullName = fullname;
            City = city;
            BirthDay = birthDay;
            Gender = gender;
        }

        public User(object id, string fullName, string city, DateTime birthDay)
        {
            Id = id;
            FullName = fullName;
            City = city;
            BirthDay = birthDay;
        }

        public override string ToString()
        {
             return $"{FullName.PadRight(15, ' ')}";
        }





    }
    public enum Gender
    {
        male,
        female,
    }

    




}
