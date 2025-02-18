using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp_Kniznica.model
{
    public class Kniha
    {
        public string Nazov { get; set; }
        public string Autor { get; set; }
        public int ISBN { get; set; }
        public int RokVydania { get; set; }


        public Kniha(string nazov, string autor, int iSBN, int rokvzdania)
        {
            Nazov = nazov;
            Autor = autor;
            ISBN = iSBN;
            RokVydania = rokvzdania;
        }
        public void VypisInfo()
        {
            Console.WriteLine(Nazov + "nazov" + Autor + "autor" + ISBN + "ISBN" + RokVydania + "RokVydania");
        }

        public enum DruhyKnih 
        {
            Beletria,
            SciFi,
            Romanticke,
        }
    }
}
