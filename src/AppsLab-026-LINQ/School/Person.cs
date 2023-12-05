﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppsLab_026_LINQ.School
{
    public class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public string LastName { get; set; }

        public string City { get; set; }
         
        public int Age { get; set; }
        public double Height { get; set; }

    public Person(int iD, string name, string lastName, string city, int age, double height)
        {
            ID = iD;
            Name = name;
            LastName = lastName;
            City = city;
            Age = age;
            Height = height;
        }
    }
}
