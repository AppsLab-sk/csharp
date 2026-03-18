using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Xml.Linq;

namespace Cvicenie_minecraft_Wpf
{
    public class armorpart
    {

        public string DisplayName { get; set; }
        public int Armorpower { get; set; }

        public EArmorType ArmorType { get; set; }
        public EArmorPartName PartName { get; set; }
        public int XLeft { get; set; }
        public int YTop { get; set; }
        public int Width    { get; set; }
        public int Height { get; set; }

        public armorpart(string displayName, int armorpower, EArmorType armorType, EArmorPartName partName, int xLeft, int yTop, int width, int height)
        {
            DisplayName = displayName;
            Armorpower = armorpower;
            ArmorType = armorType;
            PartName = partName;
            XLeft = xLeft;
            YTop = yTop;
            Width = width;
            Height = height;
        }

        public override string ToString()
        {
            return DisplayName; // or whatever property you want to show
        }
        
    }
}
