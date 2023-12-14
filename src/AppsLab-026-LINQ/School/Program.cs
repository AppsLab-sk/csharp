using System;

namespace AppsLab_026_LINQ.School // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static void Main(string[] args)
        {
            var student = new Student(0, "Sebastian", 38, "Kubinec", "Rakova", 190, "1.AI", 4);
            var teacher = new Teacher(100, "Jan", 86, "Dudo", "Zilina", 195, 1000, 10);
        }
    }
}
