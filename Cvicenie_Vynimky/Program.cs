using System.Security.Cryptography.X509Certificates;

namespace Cvicenie_Vynimky
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Nacitavanie zo subora Studenti.csv a vytvorenie studentov
             var data = File.ReadAllLines("studenti_large_chyba.csv");
             var students = new List<Student>();
             foreach (var row in data.Skip(1))
             {
                 var splits = row.Split(',');

                 try
                 {
                     var newStudent = new Student(splits[0],splits[1], splits[2], Int32.Parse(splits[3]), "I.AI", splits[4]);
                     students.Add(newStudent);
                 }
                 catch (Exception ex) 
                 {
                     Console.WriteLine(ex.Message + row);
                 }

             }
             


            //2. cvicenie, priklad na vynimky
            /*try
            {
                int[] dividers = { 0, 2, 3 };
                int value = dividers[2];
                int result = 5 / value;
                Console.WriteLine(result);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("CHYBA:  Pristup mimo rozsah pola!");  
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("CHYBA:  Delenie nulou nie je povolene!");
            }*/


          /*  Student[] students = new Student[]
            {
             new Student("1","John", "Doe", 20, "Class A", "Male"){ Grades = new List<int>(){1,2,3,4,4,2,1}},
             new Student("2","Jane", "Smith", 22, "Class B", "Female"),
             new Student("3","Sam", "Brown", 19, "Class C","Male")
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


            }*/
        }
    }
}