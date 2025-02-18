using System.ComponentModel;
using System.Diagnostics.Metrics;

namespace Cvičenie_Cykly
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /* int i = 0;
            while (i < 700)
            {
                Console.WriteLine(i);
                i++;
                if (1 == 17)
                    break;
            }

            for (int i = 0; i < 10; i++)
            {
                string riadok = ""
                for(int x = 0; x < i; x++)
                {
                    riadok += "=";
                }
                Console.WriteLine(riadok);
            }
            */



            List<string> listNames = new List<string>();

            listNames.Add("Michal");
            listNames.Add("Matúš");
            listNames.Add("Peter");
            listNames.Add("Filip");
            listNames.Add("Andrej");

            int counter = 0;
            foreach (string name in listNames)
            {
                Console.WriteLine(counter + name);
                counter++;
                
            }
        }
    }
}