﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppsLab_026_LINQ.School
{
    internal class SchoolSystem
    {
        public string FirstName { get; set; }
        public List<Student> Students { get; set; } 
        public List<Teacher> Teachers { get; set; }

        public void AddTeacher() { }
        public void AddStudent() { }
        public void RemoveTeacher() { }
        public void RemoveStudent() { }

    }
}
