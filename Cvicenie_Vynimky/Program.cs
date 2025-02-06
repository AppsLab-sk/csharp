namespace Cvicenie_Vynimky
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Nacitavanie so suboru STUDENTI.CSV
            /*
             var data = File.ReadAllLines("studenti.csv");
             var students = new List<Studenti>(); 
             foreach (var now in data.Skip(1))
             {
                 var Splits = now.Split(',');
                 var newStudent = new Studenti(Splits[1], Splits[2], Int32.Parse(Splits[3]), "I.AI");
                 students.Add(newStudent);
             }
            */


            //Priklad na vynimku pri deleni
            /*
            try
            {
                int[] deviders = { 0, 2, 3 };
                int value = deviders[2];
                int result = 5 / value;
                Console.WriteLine(result);
            }
            catch (IndexOutOfRangeException en)
            {
                Console.WriteLine("Chyba: Pristup mimo rozsah pola.");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Delenie nulou nieje povolene.");
            }
            */

            
            var data = File.ReadAllLines("studenti_large_chyba.csv");
            var students = new List<Studenti>();
            foreach (var now in data.Skip(1))
            {
                var Splits = now.Split(',');
                try
                {
                    var newStudent = new Studenti(Splits[0], Splits[1], Splits[2], Int32.Parse(Splits[3]), "I.AI", Splits[4]);
                    students.Add(newStudent);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message + " " + now);
                }
             
            }
            
            /*
            Studenti[] students = new Studenti[]
            {
                new Studenti("John", "Doe", 20, "Class A"){ Grades = new List<int>(){1,2,3,4,4,2,1}},
                new Studenti("Jane", "Smith", 22, "Class B"),
                new Studenti("Sam", "Brown", 19, "Class C")
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