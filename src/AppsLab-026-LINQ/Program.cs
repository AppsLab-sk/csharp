using AppsLab_026_LINQ.School;

public class Program
{
    static void Main()
    {
        var schoolSystem = new SchoolSystem();
        //var person = new Person();
        var student = new Student(0, "Matúš", "Abafi", "Rudinka", 8, 150, "1.AI", 5);
        var teacher = new Teacher()
        {
            ID = 10,
            FirstName = "Techer",
            LastName = "",
            City = "Mars",
            Age = 200,
            Height = 123,
            Salary = 0,
            Mood = 50,
        };

        student.AddGrade(5);
        student.AddGrade(7);

        Console.WriteLine(student.FirstName + " " + student.LastName + " : " + student.Grades.Count);
        Console.WriteLine(teacher.FirstName + " " + teacher.LastName + " : " + teacher.Salary + " " + teacher.Mood);

        
    }
}