using AppsLab_026_LINQ.School;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppsLab_026_LINQ
{
    public static class DataGenerator
    {

        public static List<string> FirstNames { get; set; } = new List<string>()
        {
        "Adam", "Peter", "Ján", "Daniel", "Karol", "Filip", "Andrej"
        };
        public static List<string> LastNames { get; set; } = new List<string>()
        {
            "Múdry", "Veľký", "Zaujímavý", "Nasypaní", "Pekný", "Vysoký"
        };
        public static List<string> Cities { get; set; } = new List<string>()
        {
            "KNM", "ZA", "BA", "CA", "KE", "MT"
        };
        public static List<string> Classes { get; set; } = new List<string>()
        {
            "I.AI", "II.BI", "I.CI", "III.BI", "II.AI", "III.CI"
        };

        public static List<Student> GenerateStudents(int numberOfStudents)
        {
            var random = new Random(6642069);
            var students = new List<Student>();

            for (int i = 0; i < numberOfStudents; i++);
            var iD = random.Next(1, 30);
            var firstaname = FirstNames[random.Next(0, FirstNames.Count())];
            var lastname = LastNames[random.Next(0, LastNames.Count())];
            var city = Cities[random.Next(0, Cities.Count())];
            var age = random.Next(15, 19);
            var height = (float)random.Next(15000, 19500) / 100f;
            var @class = Classes[random.Next(0, Classes.Count())];
            var behaviour = random.Next(1, 5);
            Student s = new Student(numberOfStudents);
            students.Add(s);
            return list;
        }

        public static List<Teacher> GenerateTeachers(int numberOfSTeachers)
        {
            for (int i = 0; i < numberOfTeachers; i++);
            var random = new Random(6642069);
            var students = new List<Student>();
            var iD = random.Next(1, 30);
            var firstaname = FirstNames[random.Next(0, FirstNames.Count())];
            var lastname = LastNames[random.Next(0, LastNames.Count())];
            var city = Cities[random.Next(0, Cities.Count())];
            var age = random.Next(25, 65);
            var height = (float)random.Next(17000, 19500) / 100f;
            var salary = (float)random.Next(70000, 120000) / 100f;
            var mood = random.Next(1, 5);
            Teacher t = new Teacher(numberOfTeachers);
            teachers.Add(t);
            return list;

        }








        }

}
