using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knižnica
{
    public class User
    {
        public string Meno { get; set; }
        public string userId { get; set; }
        public bool isAdmin { get; set; }

        public User(string meno, string userId, bool isAdmin)
        {
            Meno = meno;
            this.userId = userId;
            this.isAdmin = isAdmin;
        }

       public void VypisInfo()
       {

            Console.WriteLine("Meno" + Meno + "userId" + userId + "isAdmin" + isAdmin);
        }
        
    }
}
