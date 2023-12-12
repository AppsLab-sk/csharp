using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppsLab_026_LINQ.School
{
    internal class Person
    {
        int ID { get; set; }
        string Name { get; set; }
        string LastName { get; set; }
        
        string City { get; set; }
        int Age { get; set; }
        
        double Height { get; set; }

        public Person(int iD, string name, string lastName, string city, int age, double height)
        {
            ID = iD;
            Name = name;
            LastName = lastName;
            City = city;
            Age = age;
            Height = height;
        }
    }
}
