using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Mesto_a_obcan
{
    class Mesto
    {
        private string NazovMesta;
        private List<Obcan> obcania;


        public string nazovMesta
        {
            get { return NazovMesta; }
            set { NazovMesta = value; }
        }

        public List<Obcan> Obcania
        {
            get { return obcania; }
            set { obcania = value; }
        }
        public Mesto(string nazovMesta)
        {
            this.NazovMesta = nazovMesta;
            obcania = new List<Obcan>();
        }

        public Mesto()
        {

        }


        public void PridajObcanadomesta(Obcan obcan)
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


     
       
        }

        public void UlozDoSuboru(string nazovSuboru)
        {
            string json = JsonSerializer.Serialize(this);
            File.WriteAllText(nazovSuboru, json);
            Console.WriteLine("Data boli ulozene");
        }

        public static Mesto Nacitajzosuboru(string nazovSuboru)
        {
            if (File.Exists(nazovSuboru))
            {
                string json = File.ReadAllText(nazovSuboru);
                Mesto mesto = JsonSerializer.Deserialize<Mesto>(json);
                return mesto;
            }
            return null;

        }

    }

    
}
