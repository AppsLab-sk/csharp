using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Mesto_cvicenie
{








    public class Mesto
    {
        protected string NazovMesta { get; set; }
        protected List<Obcan> obcania { get; set; }
        protected List<Lekar> lekari { get; set; }
        protected List<Ucitelia> ucitelia { get; set; }
        protected List<Elektrikar> elektrikari { get; set; }
        protected Mesto(string nazovMesta)
        {
            NazovMesta = nazovMesta;
            obcania = new List<Obcan>();
            lekari = new List<Lekar>();
            ucitelia = new List<Ucitelia>();
            elektrikari = new List<Elektrikar>();
        }
        public void PridajElektrikaraDeMesta(Elektrikar elektrikar)
        {
            elektrikari.Add(elektrikar);
        }
        public void PridajUcitelaDoMesta(Ucitelia ucitel)
        {
            ucitelia.Add(ucitel);
        }


        public void Pridajlekaradomesta(Lekar lekar)
        {
            lekari.Add(lekar);
        }

        public Mesto()
        {
        
        
        
        
        
        }

        public void PridajObcana(Obcan obcan)
        {
            obcania.Add(obcan);
        }
        public void VypisObcanov()
        {
            Console.WriteLine("Obcania mesta " + NazovMesta);
            foreach (var obcan in obcania)
            {
                obcan.VypisInfo();
            }
            Console.WriteLine("\n");
            foreach (var lekar in lekari)
            {
                lekar.Liecenie();
            }
            Console.WriteLine("\n");



            Console.WriteLine("\n");
            foreach (var elektrikar in elektrikari)
            {
                elektrikar.kabel();
            }
            Console.WriteLine("\n");




            public void UlozDoSuboru(string nazovSuboru);
            {
                string json = JsonSerializer.Serialize(this);
                File.WriteAllText(nazovSuboru,json);
                Console.WriteLine("Data boli ulozene");

            }
        
         public static Mesto NacitajZoSuboru(string nazovSuboru
             )
            {
                if (File.Exists(nazovSuboru))
                {
                    string json = File.ReadAllText(nazovSuboru);
                    Mesto mesto = JsonSerializer.Deserialize<Mesto>(json);
                    return mesto;
                }
             return null
            }
        }
    }
} 

