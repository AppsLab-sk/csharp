using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppsLab_026_LINQ.School
{
    public class Teacher : Person
    {
        public int Salary { get; set; }
        public int Mood { get; set; }

        public Teacher(int id, string name , int age , string lastname , string city ,double height , int salary , int mood ) : base (id , name , age , lastname , city ,height)
        {
            Salary = salary;
            Mood = mood;
        }
    }
}
