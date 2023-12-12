using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppsLab_026_LINQ.School
{
    internal class Generator
    {
        public static List<string> FirstNames { get; set; } = new List<string>()
        {
        "Norbert" , "Petro" , "Maros" , "Gregor" , "Sergej" , "Jozko"
        };
        public static List<string> LastNames { get; set; } = new List<string>()
         {
        "Mrkvicka" , "Jurosik" , "Novak" , "nqoqk" , "Slniecko" , "nimarik"
          };
        public static List<string> Cities { get; set; } = new List<string>()
         {
        "Klokocov" , "Humenne" , "Prievidza" , "Cadca" , "Bardejov" , "Plosice"
        };
        public static List<string> Classes { get; set; } = new List<string>()
        {
            "I.AI" , "II.AI" , "III.AI" , "IV.BI" , "II.CI"
        };
        public static List<Student> GenerateStudents(int numberofStudents)
        {
          var random = new Random(66642069);
          var students = new List<Student>();
            var firstname = FirstNames[random.Next(0, FirstNames.Count())];
            var lastName = LastNames[random.Next(0, LastNames.Count())];
            var City = Cities[random.Next(0, Cities.Count())];
            var age = random.Next(15, 19);
            var height = (float)random.Next(15000, 18000) / 100f;
            var studentClass = Classes[random.Next(0, Classes.Count())];
            var behaviour = random.Next(1, 5);
        

            return students;
        }

    }
    
}
