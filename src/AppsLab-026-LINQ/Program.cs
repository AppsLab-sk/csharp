// See https://aka.ms/new-console-template for more information





using AppsLab_026_LINQ.School;

internal class Program
 {
    static void Main(string[] args)
    {
        var generatedStudents = DataGenerator.GenerateStudents(50);
        var generatedTeachers = DataGenerator.GenerateTeachers(10);
        SchoolSystem schoolSystem_SPSKNM = new SchoolSystem("SPSKNM", generatedStudents, generatedTeachers);
    }
 }