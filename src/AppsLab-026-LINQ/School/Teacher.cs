using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppsLab_026_LINQ.School
{
    public class Teacher : Person
    {
        public float Salary { get; set; }
        public int Mood { get; set; }

        public Teacher(int iD, string firstName, string lastName, string city, int age, double height, float salary, int mood) : base(iD, firstName, lastName, city, age, height)
        {
            Salary = salary;
            Mood = mood;
        }
    }
}
