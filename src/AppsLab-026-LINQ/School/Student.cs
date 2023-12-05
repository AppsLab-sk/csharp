using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppsLab_026_LINQ.School
{
    public class Student : Person
    {
        public string Class { get; set; }
        public int Behaviour { get; set; }
        public List<int> Grades { get; set; } = new List<int>();  

        public Student(string @class, int behaviour,   int iD, string name, string lastName, string city, int age, double height)
        {
            Class = @class;
            Behaviour = behaviour;
           
            ID = iD;
            Name = name;
            LastName = lastName;
            City = city;
            Age = age;
            Height = height;
        }
    }
}
