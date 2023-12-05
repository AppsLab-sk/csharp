﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppsLab_026_LINQ.School
{
    internal class Teacher : Person
    {
        public int Salary { get; set; }
        public int Mood { get; set; }

        public Teacher(int iD, string firstName, string lastName, string city, int age, double height, int salary, int mood)
        {
            Salary = salary;
            Mood = mood;
        }
    }
}
