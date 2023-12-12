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
        public List<int> Grades { get; set; }

        public Student(int id, string firstName, string lastName, string city, int age, double height, string @class, int behaviour, List<int> grades)

        {
            Class = @class;
            Behaviour = behaviour;
            Grades = grades;
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
            Age = age;
            Height = height;
        }
    }
}
