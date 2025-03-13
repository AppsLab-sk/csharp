using System;
using System.Runtime.Serialization.Formatters;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* string zadanecislo = Console.ReadLine() ?? "0";
             int konecnecislo = int.Parse(zadanecislo);

             int i = 0;
             while (i < konecnecislo)
             {
                 Console.WriteLine(i);
                 i++;


             }  */

            List<string> listMena = new List<string>();

            listMena.Add("Jokub");
            listMena.Add("Motus");
            listMena.Add("Bunjom");
            listMena.Add("Vlaetko");
            listMena.Add("Felipko");
            listMena.Add("Morek");

            int counter = 1;

            foreach (string meno in listMena)
            {

                Console.WriteLine(counter.ToString().PadLeft(3, '0') + ". " + meno);
                counter++;
            }


          /*  for (int i = 0; i < 99; i++)
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