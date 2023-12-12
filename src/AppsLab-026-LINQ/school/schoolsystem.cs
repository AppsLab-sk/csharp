using AppsLab_026_LINQ.School;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppsLab_026_LINQ.school
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
        public void AddTeacher(Teacher teacher)
        {
            Teachers.Add(teacher);
        }

        public void AddStudent(Student student)
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
