using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppsLab_026_LINQ.School
{
    public static class DataGenerator
    {
        public static List<string> FirstNames { get; set; } = new List<string>()
        {
         "Michal" , "Igor " , "Marek " , "Adam " , "Patrík " , "Fero "
        };
        public static List<string> LastNames { get; set; } = new List<string>()
         {
         " Martinsky " , "Naročný" , "Hrach " , "Starý" , "Mlynárik "
        };
        public static List<string> Cities { get; set; } = new List<string>()
        {
            "CA" , "MT" , "BA" , "KNM" , "ZA" , "KE"
        };
        public static List<string> Classes { get; set; } = new List<string>()
        {
            "1.AI " , "2.AI" , "3.AI" , "4.AI" , "1.BI"
        };

        public static List<Student> GenerateStudents(int numberOfStudents)
        {

            var random = new Random();
            List<Student> result = new List<Student>();
            int resultIndexID = random.Next(0, 1000);
            string firstname = FirstNames[random.Next (0, FirstNames.Count)];
            string lastname = LastNames[random.Next (0, LastNames.Count)];
            string cities = Cities[random.Next (0, Cities.Count)];
            int resuktIndexAge = random.Next(15, 19);
            double resultIndexHeight = (double)random.Next(15000, 21000) / 100.0;
            string classes = Classes[random.Next (0, Cities.Count)];
            return result;
        }
    }
}
