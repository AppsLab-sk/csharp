using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kniznica_pls_nie
{
    internal class User
    {
        public string Meno { get; set; }
        public string UserId { get; set; }
        public bool IsAdmin { get; set; }

        public User(string meno, string userId, bool isAdmin)
        {
            Meno = meno;
            UserId = userId;
            IsAdmin = isAdmin;
        }

        public void VipisInfo()
        {
            Console.WriteLine($" Meno: {Meno} UserId: {UserId} Je admin? {IsAdmin}");
        }
    }
    



}
