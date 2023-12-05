using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppsLab_026_LINQ.School
{
    internal class Student : person
    {
        public string Class { get; set; }
        public int Behaviour { get; set; } 
        public List<int> Grades { get; set; }

        

    }
}
