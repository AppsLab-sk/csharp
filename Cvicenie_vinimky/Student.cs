using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Cvicenie_vynimky
{
    internal class Student
    {
        public List<string> InappropriateNames { get; set; } = new List<string> { "Fuck", "Shit", "Idiot" };
        public int ID { get; set; }
        public string Name{ get; set; }
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
            // Check ID
            var parsed = int.TryParse(iD, out int IDResult);
            if (!parsed) 
            {
                throw new ArgumentException("Incorect ID");
            }

            // Check Name or Surname
            if (name.Length == 0 || surName.Length == 0) 
            {
                throw new ArgumentException("Incorect name or pssword");
            
            }

           

            if (InappropriateNames.Contains(name) || InappropriateNames.Contains(surName))
            {

                throw new ArgumentException("Meno je nekorektne");

            }
          
            
            ID = IDResult;
            Name = name;
            SurName = surName;
            Age = age;
            SchoolClassName = schoolClassName;
            Gender = gender;
            InappropriateNames = new List<string>();



           
           



        }
        public void AddNewGrade(int grades) 
        {
            if (grades < 1 || grades > 5) 
            {
                throw new ArgumentException("Grade must be between 1 and 5");
            
            
           
            }
            Grades.Add(grades); 
        
        
        }
    }
}
