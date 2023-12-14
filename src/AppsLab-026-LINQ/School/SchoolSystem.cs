using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppsLab_026_LINQ.School
{
    public class SchoolSystem
    {
        public string Name { get; set; }
        public List<Student> students { get; set; }
        public List<Teacher> teachers { get; set; }

        public SchoolSystem(string name, List<Student> students, List<Teacher> teachers)
        {
            Name = name;
            this.students = students;
            this.teachers = teachers;
        }

        public void AddTeacher(Teacher teacher)
        {
            teachers.Add(teacher);
        }
        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public void RemoveTeacher(Teacher teacher)
        {
            teachers.Remove(teacher);
        }

        public void RemoveStudent(Student student)
        {
            students.Remove(student);
        }
    }
}
