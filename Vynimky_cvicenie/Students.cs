using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cvicenie_Vynimky
{
    public class Student
    {
        public List<string> InappropriateNames { get; set; } = new List<string> { "Fuck", "Shit", "Idiot" };

        public int ID { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public int Age { get; set; }
        public string SchoolClassName { get; set; }
        public string Gender { get; set; }
        public List<int> Grades { get; set; }


        public Student(string name, string surName, int age, string schoolClassName)
        {
            Name = name;
            SurName = surName;
            Age = age;
            SchoolClassName = schoolClassName;
        }

        public Student(string id, string name, string surName, int age, string schoolClassName, string gender)
        {
            //Check ID
            var parsed = int.TryParse(id, out int IDResult);
            if (!parsed)
            {
                throw new ArgumentException("Incorrect ID");
            }

            //Check Name and Surname
            if (name.Length == 0  surName.Length == 0)
            {
                throw new ArgumentException("Incorrect name or surname");
            }

            ID = IDResult;
            Name = name;
            SurName = surName;
            Age = age;
            SchoolClassName = schoolClassName;
            Gender = gender;
        }


        public void AddNewGrade(int grade)
        {
            if (grade < 1 || grade > 5)
            {
                throw new ArgumentException("Grade must be between 1 and 5");
            }
            Grades.Add(grade);
        }
    }
}