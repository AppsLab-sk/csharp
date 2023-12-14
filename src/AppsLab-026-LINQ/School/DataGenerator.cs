using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppsLab_026_LINQ.School
{
    internal class DataGenerator
    {
        public static List<string> FirstName { get; set; } = new List<string>()
        {
         "Matuš" , "Tomaš" , "Martin" , "Jozef" , "Marek" , "Pavol"
        };

        public static List<string> LastName { get; set; } = new List<string>()
        {
         "Maj" , "Smrek" , "Dub" , "Kral" , "Gott" , "Vrtky"
        };
        public static List<string> Cities { get; set; } = new List<string>()
        {
         "KNK" , "KNK" , "KNK" , "KNK" , "KNK" , "KNK"
        };
        public static List<string> Classes { get; set; } = new List<string>()
        {
        "I.AI" , "IV.BI" , "I.AE" , "I.BI" , "I.AS" , "II.AI"
        };

        public static List<student> GeneatorStudents(int numberOfStudents)
        {
            List<student> result = new List<student>();
            Random rnd = new Random();

            var random = new Random();
            var students = new List<student>();
            var firstName = FirstName[random.Next(0, FirstName.Count())];
            var lastName = LastName[random.Next(0, LastName.Count())];
            var city = Cities[random.Next(0, Cities.Count())];
            var age = random.Next(15, 16);
            var height = (float)random.Next(1500000, 120000) / 100f;
            var studentClass = Classes[random.Next(0, Classes.Count())];
            var bahaviour = random.Next(10, 60);
            return result;







        }
    }
}

    
 



