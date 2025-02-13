namespace Cvicenie_vynimky
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Nacitavanie studenta
            /*var data = File.ReadAllLines("studenti.csv");
            var student = new List<Student>();
            foreach (var item in data.Skip(1)) 
            { 
              var Splits = item.Split(',');
              var newStudent = new Student(Splits[1], Splits[2], Int32.Parse(Splits[3]), "1.AI");
              student.Add(newStudent);
            }
            var aaa = 5;*/


            // Priklad na vynimku pri deleni
            /* try 
             { 
              int[] deviders = {0,2,3 };
              int value = deviders[2];
              int result = 5 / value;
              Console.WriteLine(result);           
             }
             catch (IndexOutOfRangeException ex) 
             { 
              Console.WriteLine("Chyba: Pristup mimo rozsah pola."); 

             }    
             catch (DivideByZeroException  ex)
             {
                 Console.WriteLine("Delenie nulou nieje povoleny");


             }*/

            var data = File.ReadAllLines("studenti_large_chyba.csv");
            var student = new List<Student>();
            foreach (var now in data.Skip(1))
            {

                var Splits = now.Split(',');
                try
                {
                    var newStudent = new Student(Splits[0], Splits[1], Splits[2], Int32.Parse(Splits[3]), "1.AI", Splits[4]);
                    student.Add(newStudent);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Chyba pri nacitani studenta " + now);
                }
                /* Student[] students = new Student[]
  {
                     new Student("John", "Doe", 20, "Class A"){ Grades = new List<int>(){1,2,3,4,4,2,1}},
                     new Student("Jane", "Smith", 22, "Class B"),
                     new Student("Sam", "Brown", 19, "Class C")
  };
                 var firstStudent = students[1];
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
    }   }
