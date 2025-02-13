using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*Console.WriteLine("Zadajte cislo");
            int number1 = int.Parse(Console.ReadLine());

            int i = 0;
            while (true)
            {
                Console.WriteLine(i);
                i++;
            
            if (i == number1)
            
                break;
            }*/

            /*List<string> listnames = new List<string>();

            listnames.Add(".Jan");
            listnames.Add(".Jakub");
            listnames.Add(".Michal");
            listnames.Add(".Fero");
            listnames.Add(".Martin");
            listnames.Add(".Peter");


            int poradie = 0;
            
            
            foreach (string name in listnames)            
            {
                poradie++;
                Console.WriteLine(poradie.ToString().PadLeft(5, '0') + name.ToUpper());
                
            }



            /*for (int i = 0; i < 10; i++)
            {
                string riadok = "";
                for (int x = 0; x <i; x++)
                {
                    riadok += "*";
                }
                Console.WriteLine(riadok);*/
           

            Console.WriteLine("Zadajte Meno");          

            List<string> menaList = new List<string>();

            Console.WriteLine("Mena v zozname:");
            Console.WriteLine("");
            Console.WriteLine("Zadaj meno:");
            

            while (true)
            {
                var meno = Console.ReadLine() ?? "0";

                if (meno == "exit")
                {
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Mena v zozname:");
                    menaList.Add(meno);


                    foreach (var mena in menaList)
                    {
                        Console.WriteLine(mena);
                    }
                    Console.WriteLine("");
                    Console.WriteLine("Zadaj meno:");
                }
            }

        }
    }
}