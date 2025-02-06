namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
            new Student { Name = "Anna Maria", Age = 20 },
            new Student { Name = "Anna Hruskova",Age = 40 },
            new Student { Name = "Bob", Age = 22 },
            new Student { Name = "Charlie", Age = 18 }
            };

            
            //Prehladavanie list, ziskali sme vsetkych studentov s menom Anna
            List<Student> tinedzeriStudenti_stary = new List<Student>();
             foreach(Student student in students) 
             {
                 if (student.Name.Contains("Anna"))
                 {
                     tinedzeriStudenti_stary.Add(student);
                 }
             }
            /*
             List<Student> tinedzeristudenti = students.Where(student =>  student.Age < 20).ToList();
             foreach (Student student in tinedzeriStudenti_stary)
             {
                 Console.WriteLine($"Stary sposob: Student {student.Name} ma {student.Age} a je tinedzer");
             }
            List<Student> tinedzeriStudenti_stary = new List<Student>();
             foreach(Student student in students) 
             {
                 if (student.Age < 20)
                 {
                     tinedzeriStudenti_stary.Add(student);
                 }
             }*/



            List<Student> tinedzeristudenti = students.Where(student => student.Name.Contains("Anna")).ToList();
            foreach (Student student in tinedzeristudenti)
            {
               Console.WriteLine($"LINQ: Student {student.Name} ma {student.Age} a je tinedzer");
            }
        }
    }
}