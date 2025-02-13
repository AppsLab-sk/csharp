using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mesto_cvicenie
{
    public class Elektrikar
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Elektrikar(string name, int age)
        {
            Name = name;
            Age = age;
        }



        public void kabel()
        {
            Console.WriteLine("Meno: " + Name + " Vek: " + Age + " je Elektrikar/ka");


        }
    }
}

