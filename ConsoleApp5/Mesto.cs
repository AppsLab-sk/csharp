
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ObcanMesto
{
    public class Mesto
    {
        private string nazov;
        public List<Obcan> obcania = new List<Obcan>();


        public Mesto(string nazov) 
        {
            this.nazov = nazov;
            obcania = new List<Obcan>();
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
            Console.WriteLine("Obcania mesta " + nazov + ":");

            foreach (Obcan obcan in obcania)
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

        public static Mesto NacitajZoSuboru(string nazovSuboru)
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
