using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonProblems._01_Problem
{
    public class School
    {
        public List<Student> Students { get; set; } = new List<Student>();

        public void AddNewStudent(Student student)
        {
            Students.Add(student);
        }
        public void RemoveStudent(Student student)
        {
            Students.Remove(student);
        }
    }
}
