using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppsLab_026_LINQ.School
{
    public class Teacher : Person
    {
        public int Salary {  get; set; }
        public int Mood { get; set; }

        public Teacher(int id, string firstName, string lastName, int age, double height, string city, int salary, int mood)
        {
            Salary = salary;
            Mood = mood;
        }
    }
}
