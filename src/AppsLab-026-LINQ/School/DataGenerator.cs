using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppsLab_026_LINQ.School
{
    public static class DataGenerator
    {
        public static List<string> FirstNames { get; set; } = new List<string>()
        {
            "Marek" , "Tomas" , "Pato" , "Riso" , "Andrej"
        };

        public static List<string> LastNames { get; set; } = new List<string>()
        {
            "Spokojny" , "Unaveny" , "Skaredy" , "Neskodny" , "Strasidelny"
        };

        public static List<string> Cities { get; set; } = new List<string>()
        {
            "CA" , "BA" , "KE" , "ZA" , "KNM"
        };

        public static List<string> Classes { get; set; } = new List<string>()
        {
            "1.AI" , "2.AI" , "3.AI" , "4.AI" , "1.BI"
        };

        public static List<Student> GenerateStudent(int numberOfStudents)
        {

            var random = new Random();
            List<Student> result = new List<Student>();


            for (int i = numberOfStudents; i > 0; i--)
            {
                int randomIndexId = random.Next(1, 750);
                int randomIndexFirstNames = random.Next(FirstNames.Count);
                int randomIndexLastNames = random.Next(LastNames.Count);
                int randomIndexCity = random.Next(Cities.Count);
                int randomIndexHeight = random.Next(15000, 19000 / 100);
                int randomIndexAge = random.Next(15, 20);
                int randomIndexGrades = random.Next(1, 6);
                int randomIndexClass = random.Next(Classes.Count);
                int randomIndexBehaviour = random.Next(1, 6);

                var id = randomIndexId;
                var firstname = FirstNames[randomIndexFirstNames];
                var lastname = LastNames[randomIndexLastNames];
                var city = Cities[randomIndexCity];
                var height = randomIndexHeight;
                var age = randomIndexAge;
                var grade = randomIndexGrades;
                var @class = Classes[randomIndexClass];
                var behaviour = randomIndexBehaviour;

                var student = new Student(id, firstname, age, lastname, city, height, @class, behaviour);
                result.Add(student);

            }
            return result;



        }

        public static List<Teacher> GenerateTeacher(int numberOfTeachers)
        {
            var random = new Random();
            List<Teacher> result = new List<Teacher>();

            for(int i = numberOfTeachers; i > 0; i--)
            {

                int randomIndexId = random.Next(1, 750);
                int randomIndexFirstNames = random.Next(FirstNames.Count);
                int randomIndexLastNames = random.Next(LastNames.Count);
                int randomIndexCity = random.Next(Cities.Count);
                int randomIndexHeight = random.Next(15000, 19000 / 100);
                int randomIndexAge = random.Next(23, 80);
                int randomIndexSalary = random.Next(800, 1200);
                int randomIndexMood = random.Next(1, 100);

                var id = randomIndexId;
                var firstname = FirstNames[randomIndexFirstNames];
                var age = randomIndexAge;
                var lastnane = LastNames[randomIndexLastNames];
                var city = Cities[randomIndexCity];
                var height = randomIndexHeight;
                var salary = randomIndexSalary;
                var mood = randomIndexMood;

                var teacher = new Teacher(id , firstname , age , lastnane , city , height , salary , mood );
                result.Add( teacher );

            }
            return result;
        }
    }
}
