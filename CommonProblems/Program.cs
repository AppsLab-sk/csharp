using CommonProblems._01_Problem;

namespace CommonProblems 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var SPSKNM = new School();
            
            var NovyStudent_0 = new Student();
            NovyStudent_0.Name = "Janko";
            NovyStudent_0.LastName = "Hrasko";
            NovyStudent_0.Age = 18;
            SPSKNM.AddNewStudent(NovyStudent_0);

            var NovyStudent_1 = new Student("Matko", "Fazula", 15);
            SPSKNM .AddNewStudent(NovyStudent_1);

            SPSKNM.AddNewStudent(new Student("Misko", "Sosovica", 55));
        }
    }
}