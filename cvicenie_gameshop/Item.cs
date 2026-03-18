using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cvicenie_gameshop
{
    public class Item
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int Level { get; set; }

        public override string ToString()
        {
            return $"{Name} (Hodnota: {Price}, Level: {Level})";
        }


    }
}
