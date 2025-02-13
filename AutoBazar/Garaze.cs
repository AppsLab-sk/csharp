using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace AutoBazar
{
    internal class Garaze
    {
        public List<Auto> ZoznamAut { get; set; }
        public List<Auto> Oblubeny { get; set; }



        public Garaze()
        {
            ZoznamAut = new List<Auto>();
            Oblubeny = new List<Auto>();

        }

        public Garaze(List<Auto> zoznamAut)
        {
            ZoznamAut = zoznamAut;
        }
        public void PridajAuto(Auto auto)
        {
            ZoznamAut.Add(auto);

        }


        public void OdstranjAuto(int indexAuta)
        {
            if (indexAuta < 0)
            {
                Console.WriteLine("Bud ho niekto ukradol alebo jednoducho neexistuje.");
                return;
            }
            Auto vybraneAuto = ZoznamAut.Where(x => x.ID == indexAuta).First();
            ZoznamAut.Remove(vybraneAuto);
            Oblubeny.Remove(vybraneAuto);


        }
        public void OdstranjOblubeneAuto(int indexOblu)
        {
            if (indexOblu < 0)
            {
                Console.WriteLine("Bud ho niekto ukradol alebo jednoducho neexistuje.");
                return;
            }
            Auto vybraneAuto = ZoznamAut.Where(x => x.ID == indexOblu).First();
            Oblubeny.Remove(vybraneAuto);
            ZoznamAut.Remove(vybraneAuto);

        }

        public void PridajOblubene(int indexOblu)
        {
            if (indexOblu < 0)
            {
                Console.WriteLine("Bud ho niekto ukradol alebo jednoducho neexistuje.");
                return;
            }

            Auto vybraneAuto = ZoznamAut.FirstOrDefault(x => x.ID == indexOblu);

            if (Oblubeny.Contains(vybraneAuto))
            {
                Console.WriteLine("Toto auto je už pridané medzi obľúbené.");
                return;
            }

            Oblubeny.Add(vybraneAuto);
            Console.WriteLine($"Auto {vybraneAuto.Znacka} {vybraneAuto.Model} bolo pridané medzi obľúbené.");
        }
        public void VypisOblubene() 
        {
            for (int i = 0; i < Oblubeny.Count; i++)
            {

                Oblubeny[i].VypisInfo();
                Console.WriteLine();
            }
        }
        public void VypisVsetkyAuta()
        {
            for (int i = 0; i < ZoznamAut.Count; i++)
            {
               
               ZoznamAut[i].VypisInfo();
                Console.WriteLine();
            }
           
        }
        public void VypocitajCenuPredaju(int indexAuta)
        {
           
            if (indexAuta < 0 )
            {
                Console.WriteLine("Bud ho niekto ukradol alebo jednoducho neexistuje.");
                return;
            }
            Auto vybraneAuto = ZoznamAut.Where(x => x.ID == indexAuta).First();
            double cenaPredaju = vybraneAuto.Cena;
            Console.WriteLine($"Auto znacky {vybraneAuto.Znacka} {vybraneAuto.Model} je predane za {cenaPredaju} eur.");
        }
        
    }
}
