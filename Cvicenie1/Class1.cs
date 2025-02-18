using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Cvicenie1
{
    public class Class1
    {
        public int x { get; set; }
        public int y { get; set; }

        public Class1(int x, int y)
        {
            this.x = x;
            this.y = y;    // rozlisenie (this)

        }

        public int Obsah()
        {
            return x * y;
        }
    }
}
