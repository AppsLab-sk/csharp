using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppsLab_026_LINQ.School
{
    internal class SchoolSystem
    {
        public string name { get; set; }
        public List<Student> Students { get; set; }
        public List<Teacher> Teachers { get; set; }
        public void AddTeacher { get; set; }
        public void AddStudent { get; set; }
        public void RemoveTeacher { get; set; }
        public void RemoveStudent {  get; set; }
}
