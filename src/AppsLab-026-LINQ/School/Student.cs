using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppsLab_026_LINQ.School
{
    internal class Student : Person 
    {
       public string Class { get; set; }
        public int Behavior { get; set; }
        public List<int> Grades { get; set;}
        public Student(string @class, int behavior, List<int> grades)
        {
            Class = @class;
            Behavior = behavior;
            Grades = grades;
        }
    }
}
