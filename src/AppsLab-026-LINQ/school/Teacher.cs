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
        public int Mood { get; set; } // percento, podla toho aky ma mod bude davat znamy , ci viac ho ziaci nahnevaju tym bude davat horsie znamky    

        public Teacher() : base()
        {
        }
    }
}