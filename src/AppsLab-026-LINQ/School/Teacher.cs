﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppsLab_026_LINQ.School
{
    public class Teacher : Person
    {
        public int Salary { get; set; }
        public int Mood { get; set; }


        public Teacher(int iD, string name, string lastName, string city, int age, double height, int salary, int mood ) 
        : base(iD,name,lastName,city,age,height)
     {       
            Salary = salary;
            Mood = mood;
            ID = iD;
            Name = name;
            LastName = lastName;
            City = city;
            Age = age;
            Height = height;

        }
            
    }
}
