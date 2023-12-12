using AppsLab_026_LINQ.School;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppsLab_026_LINQ
{
    public class SchoolSystem
    {
        public string Name { get; set; }
        public List<Student> Students { get; set; } = new List<Student>();
        public List<Teacher> Teachers { get; set; } = new List<Teacher>();

       
        public SchoolSystem(string name, List<Student> students, List<Teacher> teachers)
        {
            Name = name;
            Students = students;
            Teachers = teachers;

        }
    
    }
    
}
