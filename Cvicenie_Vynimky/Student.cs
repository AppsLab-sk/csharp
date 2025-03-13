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
        public int ID { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public int Age { get; set; }
        public string SchoolClassName { get; set; }
        public string Gender { get; set; }
        public List<int> Grades { get; set; } = new List<int>();



        public Student(string iD, string name, string surName, int age, string schoolClassName, string gender)
        {
            var parsed = int.TryParse(iD, out int IdResult);
            if (!parsed)
            {
                throw new ArgumentException("ERROR: ID can not parse: ");

            }

            if (name.Length == 0 || surName.Length == 0)
            {
                throw new ArgumentException("ERROR: Incorrect name or surename: ");
            }

            if (InappropriateNames.Contains(name))
            {
                throw new ArgumentException("ERROR: Student has inappropraite name or surename: ");

            }

            if (InappropriateNames.Contains(surName))
            {
                throw new ArgumentException("ERROR: Student has inappropraite name or surename: ");
            }

            ID = IdResult;
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
                throw new ArgumentException("ERROR: Grade must be between 1 and 5");
            }
            Grades.Add(grade);
        }
    }   
}
