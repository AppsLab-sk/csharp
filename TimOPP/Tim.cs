using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TimOPP
{
    class Tim
    {
        public string Nazov { get; private set; } 
        public static int PocetTimov { get; private set; }

        
        public Tim(string nazov)
        {
            Nazov = nazov;
            PocetTimov++; 
        }

       
        public static int ZiskajPocetTimov()
        {
            return PocetTimov;
        }
    }
}
