using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace AppsLab_026_LINQ.School
{
    public class Teacher : Person
    {
        public int Salary { get; set; }
        public int Mood { get; set; }

        public Teacher()
        {
        }

        public Teacher(int iD, string firstName, string lastName, string city, int age, double height, int salary, int mood) : base(iD, firstName, lastName, city, age, height)
        {
        }
    }

    
}
