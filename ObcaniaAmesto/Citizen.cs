using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObcaniaAmesto
{
    public class Citizen
    {
        protected string name;
        protected int age;
        protected StavObcana stav;


        public string Name
        {
            get { return name; } 
            set {  name = value; }
        }

        public int Age 
        { 
            get { return age; }
            set { age = value; }
        }

        public StavObcana Stav
        {
            get { return stav; }
            set { stav = value; }
        }

        public Citizen(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public Citizen()
        {
        }

        public virtual void VypisInfo()
        {           
            Console.WriteLine("Meno: " + Name + ", Vek: " + Age + ", Stav: " + Stav);           
        }

        public virtual void VypisVek()
        {
            Console.WriteLine("Vek: " + Age);
        }
    }

    public enum StavObcana
    {
        Domaci,
        Cudzinec,
        Turista
    }

}
