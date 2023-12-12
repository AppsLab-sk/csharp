using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppsLab_026_LINQ.School
{
    public static class DataGenerator
    {
        public static List<string> FirstName = new List<string>()
        {
            "Tomaš", "Matúš", "Michal", "Igor", "Adam"
        };

        public static List<string> LastName = new List<string>()
        {
            "Nespokojny", "Murín", "Spokojny", "Abafi", "Unaveny"
        };

        public static List<string> Cities = new List<string>()
        {
            "Ru", "ZA", "KM", "BB", "MT"
        };

        public static List<string> Classes = new List<string>()
        {
            "I.AI", "II.AI", "III.AI", "IV.AI", "I.AI"
        };

        public static List<Student> GenerateStudents(int numberOfStudents)
        {
            List<Student> result = new List<Student>();
            Random rnd = new Random();

            for (int i = numberOfStudents; i > 0; i--)
            {
                int rndIndexID = rnd.Next(0, 1000);
                int rndIndexFN = rnd.Next(FirstName.Count);
                int rndIndexLN = rnd.Next(LastName.Count);
                int rndIndexCi = rnd.Next(Cities.Count);
                int rndIndexAg = rnd.Next(14, 18);
                int rndIndexHg = rnd.Next(15000, 21000) / 100;
                int rndIndexCl = rnd.Next(Classes.Count);
                int rndIndexBh = rnd.Next(0, 10);

                int ID = rndIndexID;
                string firstName = FirstName[rndIndexFN];
                string lastName = LastName[rndIndexLN];
                string city = Cities[rndIndexCi];
                int age = rndIndexAg;
                double height = rndIndexHg;
                string clas = Classes[rndIndexCl];
                int behavior = rndIndexBh;

                var student = new Student(ID, firstName, lastName, city, age, height, clas, behavior);

                result.Add(student);
            };
            return result;
        }

        public static List<Teacher> GenerateTeachers(int numberOfTeachers)
        {
            List<Teacher> result = new List<Teacher>();
            Random rnd = new Random();

            for (int i = numberOfTeachers; i > 0; i--)
            { 
            
            }

            return result;
        }

    }
}
