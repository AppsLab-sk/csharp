namespace cvicenie_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Student> students = new List<Student>()
            {
    new Student { Name = "Anna Maria", Age = 20 },
    new Student { Name = "Bob", Age = 22 },
    new Student { Name = "Charlie", Age = 18 },
    new Student { Name = "Anna Hruskova",Age =40}    
            };
           
            /*
            List<Student> tinedzeriStudenti_StarySposob = new List<Student>();
            foreach (Student student in students)
            {
                if (student.Age < 20)
                {
                    tinedzeriStudenti_StarySposob.Add(student);
                }
            }
            */ /*
        foreach (Student student in students)
           if (student.Age < 20)
            {
                    Console.WriteLine($"student {student.Name} ma {student.Age} a je tinedzer.");
            }
            */
             
            List<StStudent.ents.Where(x => student.Name == "Bob" ).ToList();

            foreach (Student student in tinedzeriStudenti)
            {

                Console.WriteLine($"LINQ:student,{student.Name} ma {student.Age} a je tinedzer.");
            }  
             

            

        }
    }
} 