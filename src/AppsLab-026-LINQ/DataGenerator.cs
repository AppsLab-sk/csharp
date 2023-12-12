﻿using AppsLab_026_LINQ.School;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppsLab_026_LINQ
{
    public static class DataGenerator
    {

        public static List<string> FirstNames { get; set; } = new List<string>()
        {
        "Adam", "Ján", "Alfonz", "Sergej", "Alfredy", "Kornélius", "Alojz", "Oktavius"
        };
        public static List<string> LastNames { get; set; } = new List<string>()
        {
        "Belý", "Alpa", "Snežný", "Koliesko", "Novotný", "Pekný", "Jahoda", "Baník"
        };
        public static List<string> Cities { get; set; } = new List<string>()
        {
        "ZA", "BA", "BB", "KE", "KNM", "Streda nad Bodrogom", "PB", "PO"
        };
        public static List<string> Classes { get; set; } = new List<string>()
        {
        "I.AI", "II.AI", "III.AI", "IV.AI", "I.BI", "II.BI", "III.BI", "IV.BI"
        };

        public static List<Student> GenerateStudents(int numberofstudents)
        {
            
            var random = new Random();
            var students = new List<Student>();

            for (int i = 0; i < numberofstudents; i++) ;
            var id = random.Next(1, 15);
            var firstname = FirstNames[random.Next(0, FirstNames.Count())];
            var lastname = LastNames[random.Next(0, LastNames.Count())];
            var city = Cities[random.Next(0, Cities.Count())];
            var @class = Classes[random.Next(0, Classes.Count())];
            var age = random.Next(15, 19);
            var height = (float)random.Next(16000, 21000) / 100f;
            var behaviour = random.Next(1, 5);
            Student s = new Student(id, firstname, lastname, age, height, city, @class, behavior);
            students.Add(s);
            return s;

        }

        public static List<Teacher> GenerateTeachers(int numberofteachers) // cycle, list, generate students(count), generate teachers(count), 
        {

            
            var random = new Random();
            var teachers = new List<Teacher>();

            for (int i = 0; i < numberofteachers; i++) ;
            var id = random.Next(1, 15);
            var firstname = FirstNames[random.Next(0, FirstNames.Count())];
            var lastname = LastNames[random.Next(0, LastNames.Count())];
            var city = Cities[random.Next(0, Cities.Count())];
            var salary = (float)random.Next(70000, 120000) / 100f;
            var age = random.Next(30, 68);
            var height = (float)random.Next(16000, 21000) / 100f;
            var mood = random.Next(1, 5);
            Teacher t = new Teacher(numberofteachers);
            teachers.Add(t);
            return t;
        }

    }   
}
