using AppsLab_026_LINQ;

List<student> students = new List<student>();
students.Add(new student { Name = "David", Age = 16 });
students.Add(new student { Name = "Patrik", Age = 15 });
students.Add(new student { Name = "Alex", Age = 15 });
students.Add(new student { Name = "Michal", Age = 15 });
students.Add(new student { Name = "Kristian", Age = 16 });
students.Add(new student { Name = "Fabio", Age = 16  });
students.Add(new student { Name = "Lukas", Age = 15 });
students.Add(new student { Name = "Michal", Age = 15 });
students.Add(new student { Name = "Matus", Age = 15 });
students.Add(new student { Name = "Michal", Age = 15 });
students.Add(new student { Name = "Marek", Age = 18 });
students.Add(new student { Name = "Michal", Age = 15 });
students.Add(new student { Name = "Matej", Age = 15 });
students.Add(new student { Name = "Rudo", Age = 16 });

var outputStudents = students.GroupBy(s => s.Name);

foreach(var student in outputStudents)
{
    Console.WriteLine($"Meno: {student.Key}");
}
