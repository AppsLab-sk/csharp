using AppsLab_026_LINQ;
using AppsLab_026_LINQ.School;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*var student = new Student(0, "Adam", "Pekny", "KNM", 15, 1.5, "I.AI", 1);
            var teacher = new Teacher() { ID = 1, FirstName = "Michal", LastName = "Posledny", City = "KNM", Age = 15, Height = 1.5, Mood = 50, Salary = 2541};*/

            var generatedStudents = DataGenerator.GenerateStudents(50);
            var generatedTeachers = DataGenerator.GenerateTeachers(10);
            SchoolSystem schoolSystem_SPSKNM = new SchoolSystem("SPSKNM", generatedStudents, generatedTeachers);


            //Ziskat ID vsetkych ucitelov ktory sa volaju Adam aby im skola mohla kupit nieco pod stromcek
            var teachersWithAdamName = schoolSystem_SPSKNM.Teachers.Where(x => x.FirstName == "Adam").ToList();
            Console.WriteLine("Zoznam IDciek Adamov:");
            Console.WriteLine("-----------------------------------");
            foreach (var teacher in teachersWithAdamName)
            {
                Console.WriteLine(teacher.ID);
            }
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine("\n");

            //Studentov ktory maju 18 a viac rokov
            var adultStudents = schoolSystem_SPSKNM.Students.Where(x => x.Age >= 18).ToList();
            Console.WriteLine("Zoznam dospelych studentov:");
            Console.WriteLine("-----------------------------------");
            foreach (var student in adultStudents)
            {
                Console.WriteLine(student.ToString());
            }
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            //Ucitiela ktorz maju plat od 1500 do 2000;
            var teachersWithNeededSalary = schoolSystem_SPSKNM.Teachers.Where(x => x.Salary >= 1500 && x.Salary <= 2000).ToList();
            Console.WriteLine("Zoznam ucitelov ktory maju od 1500 do 2000 vyplatu");
            Console.WriteLine("-----------------------------------");
            foreach (var teacher in teachersWithNeededSalary)
            {
                Console.WriteLine(teacher.ToString());
            }
        }
    }
}