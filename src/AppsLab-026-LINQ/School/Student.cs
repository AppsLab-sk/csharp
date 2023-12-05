using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppsLab_026_LINQ.School
{
    public class Student : Person
    {
        public string Class {  get; set; }
        public int Behavior { get; set; }
        public List<int> Grades { get; set; } = new List<int>();

        public Student(int iD, string firstName, string lastName, string city, int age, double height, string @class, int behavior) : base (iD, firstName, lastName, city, age, height)
        {
            Class = @class;
            Behavior = behavior;
        }

        public void AddGrade(int grade)
        {
            Grades.Add(grade);
        }
    }
}
