using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppsLab_026_LINQ.School
{
    public class Student : Person
    {
        public string Class { get; set; }
        public int Behaviour { get; set; }
        public List<int> Grades { get; set; } = new List<int>();

        public Student(int id, string name, int age, string lastame, string city, double heihgt , string @class , int behaviour ) : base ( id, name, age,lastame,city, heihgt)
        {
            Class = @class;
            Behaviour = behaviour;
            
        }
    }
}
