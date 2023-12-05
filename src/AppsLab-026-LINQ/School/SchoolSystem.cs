﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppsLab_026_LINQ.School
{
    internal class SchoolSystem
    {
        string Name { get; set; }
        List<Student> Students { get; set; }
        List<Teacher> Teachers { get; set; }

        void AddStudent(Student student)
        {
            Students.Add(student);
        }
        void RemoveStudent(Student student)
        {
            Students.Remove(student);
        }
        void AddTeacher(Teacher teacher)
        {
            Teachers.Add(teacher);
        }
        void RemoveTeacher(Teacher teacher)
        {
            Teachers.Remove(teacher);
        }
    }
}
