using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Cvicenie
{
    public class Vehicle
    {
        public string EvidencneCisloAuta { get; set; }
        public int RokVyroby { get; set; }
        public bool JePlatnaSTK { get; set; }
        public double Spoteba { get; set; }
        public string TypMotora { get; set; } //D = Diesel B = Benzin PE = Posrata Elektrika

        public Vehicle()
        {

        }

        public Vehicle(string evidencneCisloAuta, int rokVyroby, bool jePlatnaSTK, double spoteba, string typMotora)
        {
            EvidencneCisloAuta = evidencneCisloAuta;
            RokVyroby = rokVyroby;
            JePlatnaSTK = jePlatnaSTK;
            Spoteba = spoteba;
            TypMotora = typMotora;
        }


        public string VypisAuta(bool chcete)
        {
            if (chcete)
            {
                var informacie = $"SPZ:{EvidencneCisloAuta},Rok:{RokVyroby},STK:{JePlatnaSTK}" +
                $"Spotreba:{Spoteba},Motor:{TypMotora}";
                return informacie;
            }
            else
            {
                var informacie = $"SPZ:{EvidencneCisloAuta},Rok:{RokVyroby},STK:{JePlatnaSTK}";
                return informacie;
            }
        }
    }
}
