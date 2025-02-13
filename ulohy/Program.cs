using System;

internal class Program
{
    static void Main(string[] args)
    {

        /*int vek = 16 ;
        string meno = "Jan" ;
        bool isstudent = true ;
        double vyska = 1.70 ;

        Console.WriteLine("Moj vek je "+vek +" rokov"+"\n"  + "Moje meno je "+meno + "\n" + 
            "Som student "+isstudent + "\n" + "Moja vyska je "+ vyska + " metra"+ "\n");*/

        /*Console.WriteLine("Napis vek");
        var vek = Console.ReadLine();
        int vekdva = int.Parse(vek);

        if (vekdva >= 18)
        {
            Console.WriteLine("Si dospely");
        }
        else
        {                                                                                            
            Console.WriteLine("Nie si dospely");
        }*/

        /* Random rnd = new Random();
         int vygeneradovane = rnd.Next(maxValue:100);
         Console.WriteLine("Napis cislo");
         string hadame = Console.ReadLine() ?? "0"; 
         int hademedva = int.Parse(hadame);*/

        
        Random rnd = new Random();
        int vygeneradovane = rnd.Next(maxValue: 100);
        int pokus = 0;
        int tip = 0;
        int maximum = 10;

        

        while (tip!= vygeneradovane)
        {
            Console.WriteLine("Napis cislo");
            tip = int.Parse(Console.ReadLine());

            pokus++;
            

            if (tip > vygeneradovane)
            {
                Console.WriteLine("Cislo je velke");
            }
            else if ( tip < vygeneradovane)
            {
                Console.WriteLine("Cislo je male");
            }           
            else if (tip == vygeneradovane) 
            {
                Console.WriteLine("Gratulujem uhadol si cislo." + " Mal si " + pokus +" pokusov.");
                break;
            }
            if (pokus == maximum)
            {
                Console.WriteLine("Vyprsal ti maximalny pocet pokusov");
                break;
            }
        }

    }

}



