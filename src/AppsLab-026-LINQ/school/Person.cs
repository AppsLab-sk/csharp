using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppsLab_026_LINQ.school
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int Id { get; set; }
        public string City { get; set; }
        public double Height { get; set; }

        public Person(string firstName, string lastName, int age, int id, string city, double height)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Id = id;
            City = city;
            Height = height;
        }
    }
}
