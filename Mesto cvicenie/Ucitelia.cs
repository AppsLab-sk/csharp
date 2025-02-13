using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Mesto_cvicenie
{
    public class Ucitelia : Obcan
    {
        public string ucenie;
        public Ucitelia(string Name, int Age, string ucenie) : base(Name, Age) { }

         { 
        this.ucenie=ucenie
    }
        public void VypisInfo()
        {
            Console.WriteLine("Meno: " + Name + " Vek: " + Age + " je ucitel/ka");


        }
    }
}

