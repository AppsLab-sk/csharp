using AppsLab_026_LINQ.School;
using AppsLab_026_LINQ;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var generateStudents = DataGenerator.GenerateStudents(50);
            var generateTeachers = DataGenerator.GenerateTeachers(10);
            SchoolSystem schoolSystemA = new SchoolSystem("SPSKNM", generateStudents, generateTeachers);


            var sknm = schoolSystemA.Students.Where(x => x.City == "KNM").ToList();
            Console.WriteLine("Zoznam študentov žijúcich v Kysuckom Novom Meste");
            foreach (var student in sknm) 
            {
                Console.WriteLine("ID: " + student.ID + " Name: " + student.FirstName + " Surname: " + student.LastName + " City:" + student.City + " Class: " + student.Class + " Behavior: " + student.Behavior + " Grades: " + student.Grades);
            }

            

        }
    }
}