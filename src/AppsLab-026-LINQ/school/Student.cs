using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppsLab_026_LINQ.school
{
    public class Student:Person
    {
        public string Class { get; set; }  
        public List<int> Grades { get; set; } = new List<int>();
        public int Behavior { get; set; }

        public Student(string firstName, string lastName, int age, int id, string city, double height, string @class, int behavior)
        {
            Class = @class;
            Behavior = behavior;
        }
    }
}
