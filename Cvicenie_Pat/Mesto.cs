using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Cvicenie_Pat
{
    internal class Mesto
    {
        private string mesta;
        private List<Obcan> obcanie;

        public string Mesta 
        { 
          get { return mesta; } 
          set { mesta = value; }      
        } 

        public List<Obcan> Obcania 
        {
            get { return obcanie; } 
            set { obcanie = value; }
        
        } 
        

        public Mesto(string mesta)
        {
            Mesta = mesta;
            Obcania = new List<Obcan>();          
              
      
        }      
        public Mesto() 
        { 
        
        }
        public void PridajObcanadomesta(Obcan obcan) 
        {
            Obcania.Add(obcan);
        }
        
        public void VypisObcanov()
        {                      
            Console.WriteLine("Obcania mesta " + Mesta);

            foreach (var obcan in Obcania)
            {
                obcan.VypisInfo();
               
            }                                                                 
        }
        public void UlozdoSuboru(string nazovsuboru) 
        {
            string json = JsonSerializer.Serialize(this);
            File.WriteAllText(nazovsuboru, json);
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
