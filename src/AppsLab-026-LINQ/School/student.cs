using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppsLab_026_LINQ.School
{
   public class student:Person
    {
        string Class {  get; set; }
        int Behaviour { get; set; }
        List<int> Grades { get; set; }

        public student(int ID, string name, string lastName, string city, int age, double heigh) : base(ID,name,lastName,city,age,heigh)
        {
            Class = Class;
            Behaviour = Behaviour;
            Grades = Grades;
        }
    }
}
