using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektKniznica
{
    public class User
    {
        public string meno { get; set; }
        public string userId { get; set; }
        public bool isAdmin { get; set; }

        public User(string meno, string userId, bool isAdmin)
        {
            this.meno = meno;
            this.userId = userId;
            this.isAdmin = isAdmin;
        }

        public void VypisInfo()
        {
            Console.WriteLine($"USER>>> MENO: {this.meno}, USER ID: {this.userId}, ADMIN: {this.isAdmin}");
        }
    }
}
