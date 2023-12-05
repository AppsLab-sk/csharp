using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppsLab_026_LINQ.School
{
    internal class Student : Person 
    {
        public string Class { get; set; }
        public int Behaviour { get; set; }
        public List<int> Grades { get; set; }

        public Student(string @class, int behaviour, List<int> grades , int iD, string firstName, string lastName, string city, int age, double height)
        {
            Class = @class;
            Behaviour = behaviour;
            Grades = grades;
            ID = iD;
            FirstName = firstName;
            LastName = lastName;
            City = city;
            Age = age;
            Height = height;
        }
    }
}
