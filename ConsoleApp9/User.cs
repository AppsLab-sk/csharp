using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    public class User
    {
        public string Name { get; set; }
        public string UserId { get; set; }
        public bool IsAdmin { get; set; }

        public User(string name, string userId, bool isAdmin)
        {
            Name = name;
            UserId = userId;
            IsAdmin = isAdmin;
        }

        public void VypisInfo()
        {
            Console.WriteLine($"Meno:" + Name + "User Id: " + UserId + "Is Admin: " + IsAdmin);
        }
    }
}
