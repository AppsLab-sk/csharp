using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kniznica
{
    public class User
    {
        public string Meno { get; set; }
        public string UserId { get; set; }
        public bool isAdmin { get; set; }

        public User(string meno, string userId, bool isAdmin)
        {
            Meno = meno;
            UserId = userId;
            this.isAdmin = isAdmin;
        }

        public void VypisInfo()
        {
            Console.WriteLine($"Meno: {Meno}, UserID: {UserId}, IsAdmin: {isAdmin}");
        }
    }
}
