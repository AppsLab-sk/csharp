using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppsLab_026_LINQ.School
{
    public class Teacher : Person
    {
        public float Salary {  get; set; }
        public int Mood { get; set; }

        public Teacher(int id, string firstName, string lastName, int age, double height, string city, float salary, int mood) : base (id, firstName, lastName, age, height, city)
        {
            Salary = salary;
            Mood = mood;
        }
    }
}
