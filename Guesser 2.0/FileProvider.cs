using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guesser_2._0
{
    internal class FileProvider
    {

        public int LoadMaxNumber(string filename)
        {
            string fileContent = File.ReadAllText(filename);
            int maxNumber = Convert.ToInt32(fileContent);

            return maxNumber;
        }
    }
}
