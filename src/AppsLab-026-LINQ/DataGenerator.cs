using AppsLab_026_LINQ.school;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Resolvers;

namespace AppsLab_026_LINQ
{
    public class DataGenerator
    {




        public static List<string> FirstName { get; set; } = new List<string>()
    {
        "Tomík","Marťas","Jaro", "Marek", "Matej"
    };

        public static List<string> LastName { get; set; } = new List<string>()
    {
      "nofoter","Gaming","Guzma","Marek","Matej"
    };
        public static List<string> Cities { get; set; } = new List<string>()
    {
        "KNK","Rudina","KNM","ZA","BA","BB",
    };
        public static List<string> Classes { get; set; } = new List<string>()
    {
     "I.AI","I.BI","I.CI","I.AT","I.AE","I.AS"
    };

        public static List<Student> GenerateStudents(int numberOfStudents)
        {
            List<Student> result = new List<Student>();


            for (int i = 0;i < numberOfStudents; i ++)
            {
                var random = new Random();
                var students = new List<Student>();
                var firstName = FirstName[random.Next(0, FirstName.Count())];
                var LastName = LastName[random.Next(0, LastName.Count())];
                var city = Cities[random.Next(0, city.Count())];
                var age = random.Next(15, 16);
                var height = (float)random.Next(1500000, 120000) / 100f;
                var studentClass = Classes[random.Next(0, Classes.Count)];
                var bahaviour = random.Next(10, 60);
                var student = new Student(2, "Marťasko", "Michalček", "Rudina", 15, 175);
                return result;
            }



        }
    }
}







