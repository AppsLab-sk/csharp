using AppsLab_026_LINQ;
using System;
using System.Globalization;
using System.Linq;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
             new Student { Name = "Anna", Age = 20 },
             new Student { Name = "Bob", Age = 22 },
             new Student { Name = "Charlie", Age = 18 },
             new Student { Name = "Anna Maria", Age = 20},
             new Student { Name = "Anna Hruskova", Age=40}
            };

           /* List<Student> teenagerStudensts_starsiSposob = new List<Student>();

            foreach (Student student in students)
            {
                if (student.Age <= 19)
                {
                    teenagerStudensts_starsiSposob.Add(student);
                }
            }*/

          /*  foreach (Student student in teenagerStudensts_starsiSposob)
            {
                Console.WriteLine($"Stary Sposob: Student {student.Name} ma {student.Age} rokov, je teenager.");
            }*/

            List<Student> teenagerStudents = students.Where(x => x.Name.Contains("Anna")).ToList();

            foreach (Student student in teenagerStudents)
            {
                Console.WriteLine($"LINQ: Student {student.Name} ma {student.Age} rokov, je teenager.");
            }
            
            List<Student> olderStudents = students.Where(x =>x.Age >= 20).ToList();

            foreach(Student student in olderStudents)
            {
                Console.WriteLine($"LINQ: Student {student.Name} ma {student.Age} rokov, je starsi student.");
            }
        }
    }
}