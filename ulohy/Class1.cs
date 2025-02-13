using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ulohy
{
    public class Rectangle
    {
        public Rectangle()
        {

        }

        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public int Width {  get; set; }
        public int Height { get; set; }


        public int Calculate()
        {
            int Result = Width * Height;
           // Console.WriteLine(Result);
            return Result;

        }
    }

}
