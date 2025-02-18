using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Mesto
    {
        public string nazov;
        public List<Obcan> obcania;

        public Mesto(string nazovMesta)
        {
            this.nazov = nazovMesta;
            obcania = new List<Obcan>();
        }

        public void PridajObcana(Obcan obcan)
        {
            obcania.Add(obcan);
        }

        public void VypisObcanov()
        {
            Console.WriteLine("Obcania mesta " + nazov + ":");
            foreach (var obcan in obcania)
            {
                obcan.VypisInfo();
            }
        }

    }

}
