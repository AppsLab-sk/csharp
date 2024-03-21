﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppsLab_026_LINQ.School
{
    public static class DataGenerator
    {

        public static List<string> FirstNames { get; set; } = new List<string>()
    {
        "Michal", "Igor", "Marek", "Adam", "Patrik", "Jan"
    };
        public static List<string> LastNames { get; set; } = new List<string>()
    {
        "Maly", "Pekny", "Vysoky", "Malina", "Hrasko", "Slepy"
    };
        public static List<string> Cities { get; set; } = new List<string>()
    {
        "KNM", "ZA", "CA", "MT", "BA", "KE"
    };
        public static List<string> Classes { get; set; } = new List<string>()
    {
        "I.AI", "II.AI", "III.AI", "IV.AI", "IV.BI"
    };

        public static List<Student> GenerateStudents(int numberOfStudents)
        {
            var random = new Random(Seed: 66642069);
            var students = new List<Student>();

            for (int i = 0; i < numberOfStudents; i++)
            {


                var firstName = FirstNames[random.Next(0, FirstNames.Count())];
                var lastName = LastNames[random.Next(0, LastNames.Count())];
                var city = Cities[random.Next(0, Cities.Count())];
                var age = random.Next(15, 19);
                var height = (float)random.Next(150, 180) / 10f;
                var StudentClass = Classes[random.Next(0, Classes.Count())];
                var behaviour = random.Next(1, 5);

                var tempStudent = new Student(i, firstName, lastName, city, age, height, StudentClass, behaviour);
                students.Add(tempStudent);
            }
            return students;
        }
    }

}