using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppsLab_026_LINQ.school
{
    public class Teacher:Person
    {
        public int Mood { get; set; }
        public int Salary { get; set; }

        public Teacher(int mood, int salary)
        {
            Mood = mood;
            Salary = salary;
        }
    }
}
