using AppsLab_026_LINQ;
using System;
using System.Linq;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
            new Student { Name = "Anna Hruskova", Age = 20 },
            new Student { Name = "Anna Maria", Age = 20 },
            new Student { Name = "Bob", Age = 22 },
            new Student { Name = "Charlie", Age = 18 }
            
            };

            /*List<Student> teenageriStudenti_StarySposob = new List<Student>();
            foreach (Student student in students)
            {
                if(student.Age < 20)
                {
                    teenageriStudenti_StarySposob.Add(student);
                    Console.WriteLine($"Student { student.Name} ma {student.Age} a je teenager");
                }
            }*/

            /*foreach (Student student in teenageriStudenti_StarySposob)
            {
                Console.WriteLine($"Stary sposob:Student,{student.Name} ma {student.Age} a je teenager");
            }*/
            
            List<Student> teenagerStudents = students.Where(x=> x.Name.Contains("Anna")).ToList();

            foreach (Student student in teenagerStudents)
            {
                Console.WriteLine($"LINQ:Student {student.Name} ma {student.Age} a ja teenager.");
            }

            List<Student> olderStudents = students.Where(x => x.Age > 20).ToList();

            foreach (Student student in olderStudents)
            {
                Console.WriteLine($"LINQ:Student {student.Name} ma {student.Age} a je starsi.");
            }
        }
    }
}
