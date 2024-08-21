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
                int ID = rnd.Next(0, 1001); 
                string firstName = FirstName[rnd.Next(FirstName.Count)];
                string lastName = LastName[rnd.Next(LastName.Count)];
                string city = Cities[rnd.Next(Cities.Count)];
                int age = rnd.Next(14, 19);
                double height = rnd.Next(15000, 21001) / 100;
                string clas = Classes[rnd.Next(Classes.Count)];
                int behavior = rnd.Next(0, 11);

                var student = new Student(ID, firstName, lastName, city, age, height, clas, behavior);

                result.Add(student);
            };
            return result;
        }

        public static List<Student> CreateStudent()
        {
            List<Student> result = new List<Student>();

            Console.WriteLine("Create new Student");
            Console.WriteLine();
            Console.WriteLine("Student ID:");
            int ID = int.Parse(Console.ReadLine());
            Console.WriteLine("Student First name:");
            string FirstName = Console.ReadLine();
            Console.WriteLine("Student Last name:");
            string LastName = Console.ReadLine();
            Console.WriteLine("Student City:");
            string City = Console.ReadLine();
            Console.WriteLine("Student age:");
            int Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Student Height:");
            double Height = int.Parse(Console.ReadLine());
            Console.WriteLine("Student Class:");
            string Class = Console.ReadLine();
            Console.WriteLine("Student Behavior:");
            int Behavior = int.Parse(Console.ReadLine());

            var student = new Student(ID, FirstName, LastName, City, Age, Height, Class, Behavior);

            result.Add(student);

            return result;
        }

        public static List<Teacher> GenerateTeachers(int numberOfTeachers)
        {
            List<Teacher> result = new List<Teacher>();
            Random rnd = new Random();

            for (int i = numberOfTeachers; i > 0; i--)
            {
                int ID = rnd.Next(1001, 2001);
                string firstName = FirstName[rnd.Next(FirstName.Count)];
                string lastName = LastName[rnd.Next(LastName.Count)];
                string city = Cities[rnd.Next(Cities.Count)];
                int age = rnd.Next(14, 18);
                double height = rnd.Next(15000, 21001) / 100;
                int salary = rnd.Next(0, 1001);
                int mood = rnd.Next(0, 101);

                var teacher = new Teacher(ID, firstName, lastName, city, age, height, salary, mood);

                result.Add(teacher);
            }

            return result;
        }

    }
}
