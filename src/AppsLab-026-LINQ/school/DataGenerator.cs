using AppsLab_026_LINQ.School;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppsLab_026_LINQ.school
{
    public class DataGenerator
    {
        public static List<string> FirstNames { get; set; } = new List<string>()
        {
            "Michal", "Igor", "Marek", "Adam", "Patrik", "Jan"
        };
        public static List<string> LastNames { get; set; } = new List<string>()
        {
            "Maly", "Pekny", "Vysoky", "Malina", "Hrasko", "Slepy"
        };
        public static List<string> Cities { get; set; } = new List<string>()
        {
            "KNM", "ZA", "CA", "MT", "BA", "KE"
        };
        public static List<string> Classes { get; set; } = new List<string>
        {
          "1.AI", "1.BI", "2.AI", "4.CI", "2.AE" , "1.AS"
        };

        public static List<Student> GenerateStudents(int numberOfStudents)



        {
            var random = new Random();
            var students = new List<Student>();
            for (int i = 0  ; i < numberOfStudents ; i++)
          {
                var id = random.Next(1,25);
            var firstName = FirstNames[random.Next(0, FirstNames.Count())];
            var lastName = LastNames[random.Next(0, LastNames.Count())];
            var city = Cities[random.Next(0, Cities.Count())];
            var age = random.Next(15, 19);
            var height = (float)random.Next(15000, 18000) / 100f;
            var studentClass = Classes[random.Next(0, Classes.Count())];
            var behavior = random.Next(1, 5);
            List <int> grades = new List<int>();
            for(int g = 0; g < 5; g++)
                {
                    grades.Add(random.Next(1, 5));

                }
            Student s = new Student(id,firstName, lastName, city, age, height, studentClass, behavior, grades );

          }
            return students;

            
        }

        public static List<Teacher> GenerateTeachers(int numberOfTeachers)
            
        {
            var random = new Random(59959994);
            var teachers = new List<Teacher>();

            for (int i = 0 ; i < numberOfTeachers ; i++)

           
            {
                var id = random.Next(1, 20);
                var firstName = FirstNames[random.Next(0, FirstNames.Count())];
                var lastName = LastNames[random.Next(0, LastNames.Count())];
                var city = Cities[random.Next(0, Cities.Count())];
                var age = random.Next(15, 19);
                var height = (float)random.Next(15000, 18000) / 100f;
                var mood = random.Next(1, 5);
                var salary = random.Next(1000, 1500);
                Teacher t = new Teacher(id, firstName, lastName, mood, age, city, salary, height);
                teachers.Add(t);
            }
            return teachers;

            


        }




        
    }
}
