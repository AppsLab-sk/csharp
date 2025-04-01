// See https://aka.ms/new-console-template for more information



using System;
using System.Security.Cryptography.X509Certificates;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int i = 0;
            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
                //i = i + 10000;


                if (i == 10)
                {
                    break;
                }

            }



            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }



            string[] names = { "Sam", "Tom", "Paulie", "Salieri" };
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }


            Console.WriteLine("zadaj cislo");
            int pocetOpakovani = int.Parse(Console.ReadLine());

            int b = 0;
            while (b < 5)
            {
                Console.WriteLine(i);
                b++;

                if (b == pocetOpakovani)

                    break;
            }

            for (int i = 0; i < 10; i++)
            {
                string riadok = "";
                for (int x = 0; x < i, x++)
                {
                    riadok += "*";
                }
                Console.WriteLine(riadok);*/
            
            int postup = 001;

            List<string> listnames = new List<string>();

            listnames.Add("Jozo");
            listnames.Add("Fero");
            listnames.Add("Andrej");
            listnames.Add("Martin");
            listnames.Add("Jakub");
            listnames.Add("Karol");

            foreach (string name in listnames)
            {
                Console.WriteLine(postup + "." + name);
                postup++;

                //Console.WriteLine(postup.ToString().PadLeft(3,´0´
            }
        }
    }
}

 

