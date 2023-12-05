using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppsLab_026_LINQ.School
{
    internal class person
    {
        public string firstName { get; set; }    
        public string LastName { get; set; }
        public string city { get; set; }
        public int age { get; set; }
        public int ID { get; set; }
        public double height { get; set; }

        public Person(int iD, string firstName, string lastName, string city, int age, double height)
        {
            ID = iD;
            FirstName = firstName;
            LastName = lastName;
            City = city;
            Age = age;
            Height = height;
        }
    }
}
}
