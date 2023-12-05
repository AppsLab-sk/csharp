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
        public int Behaviour { get; set; }
         public List<int> Grades { get; set; } = new List<int>();

        public Student(int iD, string firstName, string lastName, string city, int age, double height, string @class, int behaviour)
        {
            Class = @class;
            Behaviour = behaviour;    
        }
    }

}
