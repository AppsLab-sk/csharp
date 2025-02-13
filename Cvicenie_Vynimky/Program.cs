namespace Cvicenie_Vynimky
{
    internal class Program
    {
        static void Main(string[] args)
        {
           var data = File.ReadAllLines("studenti_large_chyba.csv");
             var students = new List<Student>();
             foreach (var row in data.Skip(1))
             {
                 var splits = row.Split(',');
                try
                {
                    var newStudent = new Student(splits[0], splits[1], splits[2], Int32.Parse(splits[3]), "I.AI", splits[4]);
                    students.Add(newStudent);
                }
                catch (Exception ex) 
                { 
                    Console.WriteLine("ERRRRROR: Chyba pri nacitani studenta" + row);
                }
             }
             

            /*Student[] students = new Student[]
            {
                   new Student("John", "Doe", 20, "Class A"){ Grades = new List<int>(){1,2,3,4,4,2,1}},
                   new Student("Jane", "Smith", 22, "Class B"),
                   new Student("Sam", "Brown", 19, "Class C")
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

            /* try
             {
                 int[] dividers = { 0, 2, 3 };
                 int value = dividers[2];
                 int result = 5 / value;
                 Console.WriteLine(result);
             }
             catch (IndexOutOfRangeException ex)
             {
                 Console.WriteLine("CHYBA: nachuj");
             }
             catch (DivideByZeroException ex)
             {
                Console.WriteLine("CHYBA");
             }     */
        }
    }
}