using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppsLab_026_LINQ.School
{
    public class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Lastname { get; set; }
        public string City { get; set; }
        public double Height { get; set; }

        public Person(int iD, string name, int age, string lastname, string city, double height)
        {
            ID = iD;
            Name = name;
            Age = age;
            Lastname = lastname;
            City = city;
            Height = height;
        }
    }
}
