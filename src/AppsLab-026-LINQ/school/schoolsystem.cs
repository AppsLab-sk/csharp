using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AppsLab_026_LINQ.school
{
    public class SchoolSystem
    {
        public string Name { get; set; }
        public List<Student> Students { get; set; }
        public List<Teacher> Teachers { get; set; }


        public void AddTeacher(Teacher teacher)
        {
            Teachers.Add(teacher);
        }
        public void Addstudtent(Student student)
        {
            Students.Add(student);
        }
        public void RemoveTeacher(Teacher teacher)
        {
            Teachers.Remove(teacher);
        }
        public void RemoveStudent(Student student)
        {
            Students.Remove(student);
        }
    }
}



