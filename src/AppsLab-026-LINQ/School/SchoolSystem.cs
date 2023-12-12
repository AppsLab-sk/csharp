using AppsLab_026_LINQ.School;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppsLab_026_LINQ.School
{
    internal class SchoolSystem
    {
        string Name { get; set; }
        List<student> Students { get; set; }
        List<teacher> teachers { get; set; }
       
        public void AddTeacher(teacher teacher)
        {
            teachers.Add(teacher);
        }

        public void RemoveTeacher (teacher teacher)
        {
            teachers.Remove(teacher);
        }

        public void AddStudent(student student)
        {
            Students.Add(student);
        }

        public void RemoveStudent(teacher teacher) 
        {
            Students.Remove(teacher);     
        }
    }
}





