using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace OOP_Cvicenie1
{
    public class Vehicle
    {
        public string EvidencneCisloAuta { get; set; }
        public int RokVyroby { get; set; }
        public bool JePlatnaSTK { get; set; }
        public double PriemernaSpotreba { get; set; }
        public char TypMotoru { get; set; }
    

        public Vehicle()
        {
        }


        public Vehicle(string evidencneCisloAuta, int rokVyroby, bool jePlatnaSTK, double priemernaSpotreba, char typMotoru)
        {
            EvidencneCisloAuta = EvidencneCisloAuta;
            RokVyroby = rokVyroby;
            JePlatnaSTK = jePlatnaSTK;
            PriemernaSpotreba = priemernaSpotreba;
            TypMotoru = typMotoru;
        }
        public string VypisAuta(bool plneInfo)
        {
            var informacie = $"SPZ:{EvidencneCisloAuta}, Rok: {RokVyroby}, STK:{JePlatnaSTK}";
            if (plneInfo)
            {
                informacie += $", Spotreba:{PriemernaSpotreba}, Motor:{TypMotoru}";
            }
            return informacie;
        }   
                    public string VypisAuta()  
        {
            var informacie = $"SPZ:{EvidencneCisloAuta}, Rok:{RokVyroby}, STK:{JePlatnaSTK}," +
                             $" Spotreba:{PriemernaSpotreba}, Motor:{TypMotoru}";
            return informacie; 
        }

    }
}
