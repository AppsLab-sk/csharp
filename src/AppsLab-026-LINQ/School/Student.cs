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

        public Student(int id, string firstName, string lastName, string city, int age, double height, string @class, int behaviour): base(id, firstName, lastName, city, age, height)

        {
            Class = @class;
            Behaviour = behaviour;
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
            Age = age;
            Height = height;
        }
    }
}
