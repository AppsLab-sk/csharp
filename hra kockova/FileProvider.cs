using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uhadni
{
    internal class FileProvider
    {
        public int LoadMaxNumber(string filename)
        {
            string fileContent = File.ReadAllText(filename);


            int maxnumber = Convert.ToInt32(fileContent);
            return maxnumber;
        }
        
    }
}
  
