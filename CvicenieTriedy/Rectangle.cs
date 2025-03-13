using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvicenieTriedy
{
    internal class Rectangle
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Rectangle()
        {

        }
        
        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public int Calculate()
        {
            int result = Width * Height;
            return result;
        }
    }
    
    

    

}
