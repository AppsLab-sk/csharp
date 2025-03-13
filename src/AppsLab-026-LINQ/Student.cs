using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppsLab_026_LINQ
{
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Student()
        {

        }

        public Student(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
