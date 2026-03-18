using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cvicenie_idlefarmer
{
    public class Plant
    {
        private string v1;
        private int v2;
        private int v3;

        public string PlantType { get; set; }
        public int Timeforharvest {  get; set; }
        public int Timeinground { get; set; }
        public int Price { get; set; }

        public Plant(string plantType, int timeforharvest, int price)
        {
            PlantType = plantType;
            Timeforharvest = timeforharvest;
          
            Price = price;

    
        
        }

        

        public override string ToString()
        {
            return $"{PlantType} {Timeinground}/{Timeforharvest}({Price}e)";
            { }




        }



    }

}
