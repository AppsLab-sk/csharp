// See https://aka.ms/new-console-template for more information
using AppsLab_026_LINQ.school;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static void Main(string[] args)
        {
            var generatedStudents = DataGenerator.GenerateStudents(50);
            var generatedTeachers = DataGenerator.GenerateTeachers(10);
            SchoolSystem schoolSystem_SPSKNM = new SchoolSystem("SPSKNM", generatedStudents, generatedTeachers);




            var sknm = schoolSystem_SPSKNM.Students.Where(x => x.City == "KNM").ToList();
            foreach (var student in sknm)
            {
                Console.WriteLine("ID: " + student.ID + "Name: ");
            }
            





        }
    }

}


