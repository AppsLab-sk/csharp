// See https://aka.ms/new-console-template for more information
using AppsLab_026_LINQ.school;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static void Main(string[] args)
        {
            var student = new Student ("Jozef", "Malinský", 16, 1, "Kysuca", 1.5, "1.AI", 1   );
            var studentDva = new Student("Hugo", "Dolinský", 15, 2, "Kysuca", 1.6, "1.BI", 2);
        }
    }
}
