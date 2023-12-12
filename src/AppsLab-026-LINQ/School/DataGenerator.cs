using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppsLab_026_LINQ.School
{
    internal class DataGenerator
    {
        public static List<string> FirstName { get; set } = new List<string>()
        {
         "Matuš" , "Tomaš" , "Martin" , "Jozef" , "Marek" , "Pavol"
        };

        public static List<string> LastName { get; set } = new List<string>()
        {
         "Maj" , "Smrek" , "Dub" , "Kral" , "Gott" , "Vrtky"
        };
        public static List<string> Cities { get; set } = new List<string>()
        {
         "KNK" , "KNK" , "KNK" , "KNK" , "KNK" , "KNK"
        };
        public static List<string> Classes { get; set } = new List<string>()
        {
        "I.AI" , "IV.BI" , "I.AE" , "I.BI" , "I.AS" , "II.AI"
        };

        public static List<student> GeneatorStudents(int numberOfStudents)
        {
            List<student> result = new List<student>();
            Random rnd = new Random();

            int rndIndexID = rnd.Next(0, 1300);
            int rndIndexFN = rnd.Next(FirstName.Count);
            int rndIndexLN = rnd.Next(LastName.Count);
            int rndIndexCi = rnd.Next(Cities.Count);
            int rndIndexAg = rnd.Next(10, 16);
            int rndIndexHG = rnd.Next(185);
            int rndIndexBh = rnd.Next(100,1300)
            return result;

            var random = new Random();
            var students = new List<student>();
            var firstName = firstNames[random.Next(0, FirstName.Count())];
            var LastName = LastName[random.Next(0, LastNameCount())];
            var city = Cities[random.Next(0, cityCount())];
            var age = random.Next(15,16)
            var height = (float)random.Next(1500000.120000) / 100f;
            var studentClass = Classes[random.Next(0, studentClass())];
            var bahaviour = random.Next(10,60)










        }
    }
        



