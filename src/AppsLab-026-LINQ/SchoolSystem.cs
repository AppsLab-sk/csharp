using AppsLab_026_LINQ.School;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AppsLab_026_LINQ
{
    public  class SchoolSystem
    { 
     
        public string Name { get; set; }
     
        
        public List<Student> students { get; set; }

        

        public List<Teacher> teachers { get ; set; }

        public SchoolSystem(string name, List<Student> students, List<Teacher> teachers)
        {
            Name = name;
            this.students = students;
            this.teachers = teachers;
        
        public void AddTeachers (Teacher teacher)
            {
                teachers.Add(teacher);
            }
        
        public void AddStudents (Student student)

            { 
                students.Add(student); 
            }
        
        
        }
    }
}
