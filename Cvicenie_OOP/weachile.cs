using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Cvicenie_OOP
{
    public class weachile
    {
        public string Cislovozidla { get; set; }

        public string Rokvyroby { get; set; }
        

        public bool JeplatnaSTK { get; set; }

        public double Spotreba { get; set; }

        public char Typmotoru { get; set; } /// diesel elektrika nafta6

        public int Prejdenekilometre { get; set; }

        public weachile()
        {
        }

        public weachile(string cislovozidla, string rokvyroby, bool jeplatnaSTK, double spotreba, char typmotoru, int prejdenekilometre)
        {
            Cislovozidla = cislovozidla;
            Rokvyroby = rokvyroby;
            JeplatnaSTK = jeplatnaSTK;
            Spotreba = spotreba;
            Typmotoru = typmotoru;
            Prejdenekilometre = prejdenekilometre;
        }
        public string VypisAuta(bool plneinfo) 
        {
            var informacie = $"SPZ:{Cislovozidla}, Rok: {Rokvyroby}, STK:{JeplatnaSTK}";
            if (plneinfo) 
            {
                informacie += $", Spotreba:{Spotreba}, Motor:{Typmotoru}";
            }
            return informacie;  
        }
        public string VypisAuta() 
        {
            var informacie = $"SPZ:{Cislovozidla}, Rok: {Rokvyroby}, STK:{JeplatnaSTK} + Spotreba:{Spotreba}, Motor: {Typmotoru}";
            return informacie;  
        }
        


    }

}