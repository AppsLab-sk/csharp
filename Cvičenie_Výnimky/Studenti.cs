using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cvičenie_Výnimky
{
    public class Studenti
    {
        public List<string> InappropriateNames { get; set; } = new List<string> { "Fuck", "Shit", "Idiot" };
        public int ID {  get; set; }
        public string Name { get; set; }
        public string SurName {  get; set; }
        public int Age { get; set; }
        public string SchoolCLassName { get; set; }
        public string Gender { get; set; }
        public List<int> Grades { get; set; } = new List<int>();


        public Studenti(string name, string surName, int age, string schoolCLassName)
        {
            Name = name;
            SurName = surName;
            Age = age;
            SchoolCLassName = schoolCLassName;
        }
        
        public Studenti(string id, string name, string surName, int age, string schoolCLassName, string gender)
        {
            // Chceck ID
            var parsed = int.TryParse(id, out int IDResult);
            if (!parsed)
            {
                throw new ArgumentException("Incorrect ID");
            }

            // Kontrola ci meno a priezvisko neni nadavka
            // Chcek Name and Surname
            if (name.Length == 0 || surName.Length == 0)
            {
                throw new ArgumentException("Incorrect name or surname");
            }
            /*if (name == fuck)
            {
                throw new ArgumentException("inncorrect name or surname");
            }*/
            if (InappropriateNames.Contains(name) || InappropriateNames.Contains(surName))
            {
                throw new ArgumentException("Incorrect name or surname");
            }


            ID = IDResult;
            Name = name;
            SurName = surName;
            Age = age;
            SchoolCLassName = schoolCLassName;
            Gender = gender;
        }

        public void AddNewGrade(int grade)
        {
            if (grade < 1 || grade >5)
            {
                throw new ArgumentException("Grade must be between 1 and 5");
            }
            Grades.Add(grade);
        }
    }
}
