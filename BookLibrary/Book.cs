using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary
{
    class Class1
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public DateTime ReleaseDate { get; set; }
        public BookGenre Genre { get; set; }
        public bool IsBorrowed { get; set; }
        public DateTime BorrowedTime { get; set; }
        public User BorrowedBy { get; set; }
    }

}
