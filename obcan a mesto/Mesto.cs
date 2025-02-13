using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace obcan_a_mesto
{
    public class Mesto
    {
        public string NazovMesta { get; set; }
        public List<Obcan> obcaniaList { get; set; }

        public Mesto()
        {

        }

        public Mesto(string nazovMesta)
        {
            NazovMesta = nazovMesta;
            this.obcaniaList = new List<Obcan>();
        
        }

        public virtual void PridajObcana (Obcan  obcan)
        { 
            obcaniaList.Add(obcan);
        }

        public virtual void VypisObcanov()
        {

            foreach (var obcan in obcaniaList)
            {
                obcan.VypisInfo();
            }
            Console.WriteLine("");
        }
        public void UlozDoSuboru(string nazovSuboru)
        {
            string json = JsonSerializer.Serialize(this);
            File.WriteAllText(nazovSuboru, json);
            Console.WriteLine("Data boli ulozene");
        }
        public static Mesto NacitajZoSuboru(string nazovSuboru)
        {
           if(File.Exists(nazovSuboru))
            {
                string json = File.ReadAllText(nazovSuboru);
                Mesto mesto = JsonSerializer.Deserialize<Mesto>(json);
                return mesto;
            }
            return null;
        }
    }
}
