using System.ComponentModel;
using System.Linq;

namespace ZakladyLINQ
{
    internal class Program
    {


        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()

            {
                new Student() { Name = "Anna Huruskova", Age = 20 },
            new Student() { Name = "Anna Maria", Age = 40 },
            new Student() { Name = "Bob", Age = 22 },
            new Student() { Name = "Charlie", Age = 18 },

            };
            List<Student> tinedzeriStudenti = students.Where(student => student.Name.Contains("Anna")).ToList();

            foreach (Student student in tinedzeriStudenti)
            {
                    Console.WriteLine($"LINQ:Student,{student.Name} ma {student.Age} a je tineger.");   
            }
            
        } 
       
    }
}