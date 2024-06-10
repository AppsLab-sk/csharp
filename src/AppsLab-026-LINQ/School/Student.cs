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
        public int Behavior { get; set; }

        public List<int> Grades { get; set; } = new List<int>();

        public Student(int id, string firstName, string lastName, int age, double height, string city, string @class, int behavior, List<int> grades) : base(id, firstName, lastName, age, height, city)
        {
            Class = @class;
            Behavior = behavior;
            Grades = grades;
        }
    }

}
