using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObcaniaAmesto
{
    public class City
    {
        public string NazovMesta { get; set; }
        public List<Citizen> Obcania { get; set; }

        public City()
        {

        }

        public City(string nazovMesta, List<Citizen> Obcania)
        {
            NazovMesta = nazovMesta;
            this.Obcania = Obcania;
        }

        public void PridajObcana(Citizen obcaniaList)
        {
            Obcania.Add(obcaniaList);
        }

        public void VypisObcanov()
        {
            foreach (var citizen in Obcania)
            {

                Console.WriteLine();
            }
        }
    }
}
