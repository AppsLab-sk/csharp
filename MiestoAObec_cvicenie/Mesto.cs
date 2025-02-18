using MiestoAObec_cvicenie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MiestoAObec_cvicenie

{
    public class mesto
    {
        public string nazov;
        public List<Obcan> obcania = new List<Obcan>();

        public mesto(string nazov)
        {
            this.nazov = nazov;
            obcania = new List<Obcan>();
        }

        public void PridajObcana(Obcan obcan)
        {
            obcania.Add(obcan);
        }
        public void VypisObcana()
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
        public static mesto NacitajZoSuboru(string nazovSuboru)
        {
            if (File.Exists(nazovSuboru))
            {
                string json = File.ReadAllText(nazovSuboru);
                mesto mesto = JsonSerializer.Deserialize<mesto>(json);
                return mesto;
            }
            return null;

        }

    }
}