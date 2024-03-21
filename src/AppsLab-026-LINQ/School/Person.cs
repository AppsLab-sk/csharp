using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AppsLab_026_LINQ.School
{
    public class Person
    {
        public int ID { get; set; }
        public string FirstName { get; set; } 
        public string LastName { get; set; }
        public int Age { get; set; }
        public double Height { get; set; }

        public string City { get; set; }

        public Person(int id, string firstName, string lastName, int age, double height, string city)
        {
            ID = id;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Height = height;
            City = city;
        }
    }
}
