using AppsLab_026_LINQ;

List<Student> students = new List<Student>();

students.Add(new Student { Name = "David", age = 16 });
students.Add(new Student { Name = "Patrik", age = 15 });
students.Add(new Student { Name = "Alex", age = 15 });
students.Add(new Student { Name = "Michal", age = 15 });
students.Add(new Student { Name = "Kristian", age = 16 });
students.Add(new Student { Name = "Fabio", age = 16 });
students.Add(new Student { Name = "Lukáš", age = 15 });
students.Add(new Student { Name = "Michal", age = 15 });
students.Add(new Student { Name = "Rudko", age = 16 });
students.Add(new Student { Name = "Michal", age = 15 });
students.Add(new Student { Name = "Matúš", age = 15 });
students.Add(new Student { Name = "Michal", age = 15 });
students.Add(new Student { Name = "Marek", age = 15 });
students.Add(new Student { Name = "Matej", age = 67 });


//List<Student> outputStudents = students.GroupBy(s = > s.Name).ToList();
var grouppedStudents = students.GroupBy(s => s.Name);

foreach (var grouppedStudent in grouppedStudents) //outputStudents)
{
    Console.WriteLine(grouppedStudent.Key); //student.Name
}

