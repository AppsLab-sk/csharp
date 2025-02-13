using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obcan_a_mesto
{
    public class Obcan
    {
        protected string name;
        protected int age;
        protected StavObcana stav;

        public string Name
        {
            get { return name; }
            set { name = value; }
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

        public Obcan(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public Obcan()
        {
        }

        public virtual void VypisInfo() 
        {
            Console.WriteLine("Meno: " + Name + ", vek: " + Age + " ,Stav: " + stav);
        }
        public void VypisVek() 
        {
            Console.WriteLine("Vek: " + Age);
        }
    }

    public enum StavObcana
    {
        
        KamiKadze,
        Terorista,
        Turista
    }
}



