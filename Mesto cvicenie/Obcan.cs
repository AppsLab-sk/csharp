using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mesto_cvicenie
{




    public class Obcan
    {
        protected string Name { get; set; }
        protected int Age { get; set; }
        protected StavObcana stav;



        public StavObcana Stav
        {


            get { return stav; }
            set { stav = value }
        } 

public Obcan(string name, int age)
{
    Name = name;
    Age = age;
}



public virtual void VypisInfo()
{
    Console.WriteLine("Meno: " + Name + "Vek: " + Age + "Stav:" + stav);


}





public enum StavObcana
{
    Domaci,
    Cudzinec,
    Turista

}


    }
}






