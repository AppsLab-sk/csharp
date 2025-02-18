using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPcvicenie
{
    public class Vehicle
    {
        public string EvidencecisloAuta { get; set; }
        public int RokVyroby { get; set; }
        public bool JePlatnaTK { get; set; }
        public double PriemernaSpotreba { get; set; }
        public char TypMotora { get; set; }      // D - diesel, B - Benzin, E - Elektro

        public Vehicle()
        {
        }

        public Vehicle(string evidencecisloAuta, int rokVyroby, bool jePlatnaTK, double priemernaSpotreba, char typMotora)
        {
            EvidencecisloAuta = evidencecisloAuta;
            RokVyroby = rokVyroby;
            JePlatnaTK = jePlatnaTK;
            PriemernaSpotreba = priemernaSpotreba;
            TypMotora = typMotora;
        }
        public string VypisAuta(bool plneInfo)
        {
           

            var informacie = $"SPZ:{EvidencecisloAuta}, Rok: {RokVyroby}, STK; {JePlatnaTK}, TypMotora: {TypMotora}, Spotreba {PriemernaSpotreba}";
            if (plneInfo)
            {
                informacie += $"SPZ:{EvidencecisloAuta}, Rok: {RokVyroby}, STK; {JePlatnaTK}, TypMotora: {TypMotora}, Spotreba {PriemernaSpotreba}";
            }

            return informacie;

        }
                             
    }
}
