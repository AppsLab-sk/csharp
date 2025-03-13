using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cvicenie_OOP
{
    public class Vehicle
    {
        public string EvidencneCisloAuta { get; set; }
        public int RokVyroby { get; set; }
        public bool JePlatnaSTK { get; set; }
        public double Spotreba { get; set; }
        public char TypMotoru { get; set; } //D - Diesel,  B - Benzin, E - Posrata Elektrika, L - Letecky Benzin, C - CNG, G - LPG, T - Trolejovo napajane, O - Olivovy olej

        public Vehicle()
        {

        }

        public Vehicle(string evidencneCisloAuta, int rokVyroby, bool jePlatnaSTK, double spotreba, char typMotoru)
        {
            EvidencneCisloAuta = evidencneCisloAuta;
            RokVyroby = rokVyroby;
            JePlatnaSTK = jePlatnaSTK;
            Spotreba = spotreba;
            TypMotoru = typMotoru;
        }
        

        public string VypisAuta(bool chcete)
        {
            var informacie = $"SPZ: {EvidencneCisloAuta}, Rok: {RokVyroby}, STK: {JePlatnaSTK},";
            if (chcete)
            {                
               informacie +=  $" Spotreba: {Spotreba}, Typ Motoru: {TypMotoru}";             
            }
            return informacie;
        }

      
    }
}
