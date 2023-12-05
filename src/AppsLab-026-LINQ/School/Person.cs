using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppsLab_026_LINQ.School
{
    internal class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public int Age { get; set; }
        public double Height { get; set; }

        public Person(int id, string firstName, string lastName, string city, int age, double height)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
            Age = age;
            Height = height;
        }
}
}
