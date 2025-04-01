using System.Linq.Expressions;

namespace Cvičenie_Výnimky
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Priklad na vynimku pri deleni nulou a nespravnym indexom
            /*
            try
            {
                int[] deviders = { 0, 2, 3 };
                int value = deviders[2];
                int result = 5 / value;
                Console.WriteLine(result);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Chyba: Pristup mimo rozsah pola.");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Chyba: Delenie nulou neni povolene.");
            }
            */

            //  Načitávanie so súbora STUDENT.CSV a vytvorenie študentov
            // Piklad na vynimky pri chybnom nacitanom subore
            
            var data = File.ReadAllLines("studenti_large_chyba.csv");
            var studenti = new List<Studenti>();
            foreach (var row in data.Skip(1))
            {
                var splits = row.Split(',');
                try
                {
                    var newStudent = new Studenti(splits[0], splits[1], splits[2], Int32.Parse(splits[3]), "I.AI", splits[4]);
                    studenti.Add(newStudent);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message + " " + row);
                }
            }
            /*
            Studenti[] students = new Studenti[]
            {
                new Studenti("John", "Doe", 20, "Class A"){ Grades = new List<int>(){1,2,3,4,4,2,1}},
                new Studenti("Jane", "Smith", 22, "Class B"),
                new Studenti("Sam", "Brown", 19, "Class C"),
            };
                var firstStudent = students[0];
                while (true)
            {
                try
                {
                    Console.WriteLine("Zadajte znamku studentovi:");
                    int znamka = Int32.Parse(Console.ReadLine());
                    firstStudent.AddNewGrade(znamka);
                    Console.WriteLine(firstStudent.Grades.Average());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            */
        }
    }
}