using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Transactions;

namespace Cvicenie_idlefarmer
{
    public class Idlefarmer
    {

        public int plantprice { get; set; } = 5;
        public int Money {  get; set; }
        public Random Randomgenerator { get; set; } = new Random();
        public int Day {  get; set; }
        public List<Plant> Field {  get; set; } =new List<Plant>();
        public List<Plant> storage { get; set; } = new List<Plant>();


        public void startgame()
        {
            Console.WriteLine("Zacala sa hra");
            Plant cibula = new Plant ("cibula", 5, 10);
            Plant pes = new Plant("pes", 40, 8);
            Plant uhorka = new Plant("uhorka", 20, 5);
            Field.Add(cibula);
            Field.Add(pes);
            Field.Add(uhorka);


            while (true)
            {


                Day++;
                foreach (Plant plant in Field)
                {
                    plant.Timeinground++;



                }
                foreach (Plant plant in Field)
                {
                    Console.WriteLine(plant);



                }
                List<Plant>harvest = new List<Plant>();
                foreach (Plant plant in Field)
                {
                   if (plant.Timeinground >= plant.Timeforharvest)
                    {
                        Console.WriteLine("rastlina nam vyrastla:"+plant);
                        harvest.Add(plant);
                    }
                }         

                foreach(Plant plant in harvest)
                {
                    Field.Remove(plant);
                    storage.Add(plant);
                }
                Console.WriteLine("koniec dna" + Day);
                Console.WriteLine("stav uctu" + Money + "$");
                Console.WriteLine("menu");
                Console.WriteLine("novyden=enter");
                Console.WriteLine("1 pridanie rastlinky" + "(" + plantprice +")");
                Console.WriteLine("2 cely storage");
                Console.WriteLine("predaj vsetko(3)");


                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        if (Money < plantprice)
                        {
                            Console.WriteLine("si chudobny jak kkt maš iba: " + Money + "$");
                            Console.ReadLine();
                            break;
                        }

                        
                        Money -= plantprice;

                        Plant plant1 = new Plant("zelenina", Randomgenerator.Next(10, 15), Randomgenerator.Next(20, 30));
                        Field.Add(plant1);

                        plantprice++;
                        Console.WriteLine("kúpil si rastlinku, zostavajúce peniaze: " + Money + "$");
                        Console.ReadLine();
                        break;
                    case "2":
                        foreach (Plant plant in storage)
                        {
                            Console.WriteLine(plant);
                        }
                        Console.ReadLine();                   /*stav += plant.Price;|pomoc chatgpt(prompt:ako to hodim do toho aby mi to case vypisal) */
                        break;
                                                                 /* Money += stav;
                                                                   break;*/
                    case "3":
                        int stav = 0;
                        foreach (Plant plant in storage)
                        {
                            stav += plant.Price; 
                        }
                        
                        Money += stav * storage.Count;
                        storage.Clear(); 

                        Console.WriteLine("predal si storage");
                        Console.WriteLine("Stav učtu:" + Money + "$" );
                        Console.ReadLine();
                        break;
                       
                    default:
                        break;
                    
                }
                
                
                
                
                
                
                
                Console.Clear();




                

            }






           


        }

    }
}
