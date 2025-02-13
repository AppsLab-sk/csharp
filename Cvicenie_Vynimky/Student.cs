using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cvicenie_Vynimky
{
    public class Student
    {
        public List<string> InappropriateNames { get; set; } = new List<string> { "Fuck", "Shit", "Idiot" };
        public string ID { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public int Age { get; set; }
        public string SchoolClassName { get; set; }
        public string Gender { get; set; }
        public List<int> Grades { get; set; } = new List<int>();

        public Student(string name, string surName, int age, string schoolClassName)
        {
            Name = name;
            SurName = surName;
            Age = age;
            SchoolClassName = schoolClassName;
        }

        public Student(string iD, string name, string surName, int age, string schoolClassName, string gender)
        {
            var parsed = int.TryParse(iD, out int IDResult);
            if (!parsed)
            {
                throw new ArgumentException("ERRROOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOooRIK!!!!!!!!!!!!!!!!!!!!!!!!!");
            }

            if(name.Length == 0 || surName.Length == 0)
            {
                throw new ArgumentException("Incorrect name or surname");
            }
            if (name == "Fuck" || name == "Shit" || name == "Idiot")
            {
                throw new ArgumentException();
            }



            ID = iD;
            Name = name;
            SurName = surName;
            Age = age;
            SchoolClassName = schoolClassName;
            Gender = gender;
        }

        public void AddNewGrade(int grade)
        {
            if(grade < 1|| grade > 5)
            {
                throw new ArgumentException("ERRRROR: si na nic");

            }
            Grades.Add(grade);
        }
    }
}