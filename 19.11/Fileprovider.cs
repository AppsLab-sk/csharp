using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generator
{
    internal class Fileprovider
    {
        public int LoadMaxNumber(string filename)
        {
            string fileContent = File.ReadAllText(filename);
            int maxNumber = Convert.ToInt32(fileContent);
            return maxNumber;
        }
    }
}
