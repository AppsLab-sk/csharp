using LINQ;
using System;
using System.Linq;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student { Name = "Anna Maria", Age = 20 },
                new Student { Name = "Anna Hruskova", Age = 20 },
                new Student { Name = "Bob", Age = 22 },
                new Student { Name = "Charlie", Age = 18 }
            };

            List<Student> tinedzeriStudenti_StarySposob = new List<Student>();

            foreach (Student student in students)
            {
                if (student.Name.Contains("Anna"))
                {
                    tinedzeriStudenti_StarySposob.Add(student);
                    Console.WriteLine($"Student {student.Name} ma {student.Age} a je tinedzer.");
                }
            }

            List<Student> tinedzeriStudenti = students.Where(student => student.Name.Contains("Anna")).ToList();

            foreach (Student student in tinedzeriStudenti) 
            {
                Console.WriteLine($"LINQ: Student,{student.Name} ma {student.Age} a je tinedzer.");
            }

        }
    }
}