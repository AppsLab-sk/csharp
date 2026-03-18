using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cvicenie_pokemon
{
    public class Hero
    {
      

        public int Helth {  get; set; }
        public int MaximumHelth { get; set; }
        public int Demage { get; set; }
        public int ActualEnergy { get; set; }
        public int MaxEnergy { get; set; }
        public Hero(int helth, int maximumHelth, int demage,int actualenergy, int maxenegry)
        {
            Helth = helth;
            MaximumHelth = maximumHelth;
            Demage = demage;
            ActualEnergy = actualenergy;
            MaxEnergy = maxenegry;              
        }
    }
}
