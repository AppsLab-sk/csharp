using AppsLab_026_LINQ.School;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AppsLab_026_LINQ.School
{
    internal class Generator
    {
        public static List<string> FirstNames { get; set; } = new List<string>()
        {
        "Norbert" , "Petro" , "Maros" , "Gregor" , "Sergej" , "Jozko"
        };
        public static List<string> LastNames { get; set; } = new List<string>()
         {
        "Mrkvicka" , "Jurosik" , "Novak" , "nqoqk" , "Slniecko" , "nimarik"
          };
        public static List<string> Cities { get; set; } = new List<string>()
         {
        "Klokocov" , "Humenne" , "Prievidza" , "Cadca" , "Bardejov" , "Plosice"
        };
        public static List<string> Classes { get; set; } = new List<string>()
        {
            "I.AI" , "II.AI" , "III.AI" , "IV.BI" , "II.CI"
        };
        public static List<Student> GenerateStudents(int numberofStudents)
        {
            var random = new Random(66642069);
            var students = new List<Student>();

            for (int i = 0; i < numberofStudents; i++)
            {
                var firstname = FirstNames[random.Next(0, FirstNames.Count())];
                var lastName = LastNames[random.Next(0, LastNames.Count())];
                var City = Cities[random.Next(0, Cities.Count())];
                var age = random.Next(15, 19);
                var height = (float)random.Next(15000, 18000) / 100f;
                var studentClass = Classes[random.Next(0, Classes.Count())];
                var behaviour = random.Next(1, 5);

                var tempStudent = new Student(i, firstname, lastName, City, age, height, studentClass, behaviour);
                students.Add(tempStudent);
            }
            return students;
        }
        public static List<Teacher> GenerateTeachers(int numberofTeachers)
        {
            var r = new Random();
            var Teachers = new List<Teacher>();

            for (int i = 0; i < numberofTeachers; i++)
            {
                var firstname = FirstNames[r.Next(0, FirstNames.Count())];
                var lastName = LastNames[r.Next(0, LastNames.Count())];
                var city = Cities[r.Next(0, Cities.Count())];
                var age = r.Next(20, 70);
                var height = (float)r.Next(15000, 18000) / 100f;
                var salary = r.Next(1000, 3000);
                var mood = r.Next(0, 100);
                Teachers.Add(new Teacher() { ID = i, FirstName = firstname, LastName = lastName, City = city, Age = age, Height = height, Salary = salary, Mood = mood });
            }
            return Teachers;

        }

    }
}

