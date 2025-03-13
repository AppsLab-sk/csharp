using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ObcaniaAmesto
{
    public class City
    {
        public string NazovMiestecka { get; set; }
        public List<Citizen> obcaniaList { get; set; }
        
        public City()
        {            
             
        }
        

        public City(string nazovMiestecka)
        {
            NazovMiestecka = nazovMiestecka;
            obcaniaList = new List<Citizen>();
        }

        public void PridajObcanov(Citizen citizen)
        {
            obcaniaList.Add(citizen);
        }

      

        public void VypisObcanov()
        {
            Console.WriteLine("Obyvatelia " + NazovMiestecka);
            foreach (var citizen in obcaniaList)
            {
                citizen.VypisInfo();
            }
            Console.WriteLine("");
        }

        public void UlozDoSuboru(string nazovSuboru)
        {
            string json = JsonSerializer.Serialize(this);
            File.WriteAllText(nazovSuboru, json);
            Console.WriteLine("Data boli ulozene");
        }

        public static City NacitajZoSuboru(string nazovSuboru)
        {
            if (File.Exists(nazovSuboru))
            {
                string json = File.ReadAllText(nazovSuboru);
                City mesto = JsonSerializer.Deserialize<City>(json);
                return mesto;
            }
            return null;
        }
    }
}
