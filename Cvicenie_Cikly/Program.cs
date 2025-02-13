using Microsoft.Win32.SafeHandles;
using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* string zadajcislo = Console.ReadLine();
             int konecnecislo = int.Parse(zadajcislo);

             int i = 0;
             while (i < konecnecislo)
             {
                 Console.WriteLine(i);
                 i++;  

             }*/

            List<string> listMena = new List<string>();

            listMena.Add("Matus");
            listMena.Add("Jakub");
            listMena.Add("Marek");
            listMena.Add("Juraj");
            listMena.Add("Mato");
            listMena.Add("Jano");


            int counter = 1;
            foreach (string mena in listMena)
            {
                Console.WriteLine(counter.ToString().PadLeft(3, '0') + ". "+ mena);
                counter++;
            }
             /*for (int i = 0; i < 10; i++)
            {
                string riadok = "";
                for (int x = 0; x < i; x++) 
                {
                    riadok += "*";
                }
                Console.WriteLine(riadok);
            }*/
        }
    }
}
