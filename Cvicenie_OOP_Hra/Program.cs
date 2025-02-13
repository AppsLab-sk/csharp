using System.Security.Cryptography.X509Certificates;

namespace Cvicenie_OOP_Hra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player KladnaPostava = new Player("Knight", 15, 100, 50, 50);

            Player ZapornaPostava = new Player("MegaKnight", 5, 300, 50, 50);

            while (true)
            {
                Console.WriteLine("Kladna postava HP:" + KladnaPostava.HP);
                Console.WriteLine("Zaporna postava HP:" + ZapornaPostava.HP);
                KladnaPostava.DamagePlayer(ZapornaPostava);
                ZapornaPostava.DamagePlayer(KladnaPostava);
                //Pokus o ozdravenie kladnej postavy a nasledny vipis ci sa to podarilo//
                if (KladnaPostava.HP <= 20)
                {
                    bool wasHealed = KladnaPostava.Heal();
                    if (wasHealed)
                    {

                        Console.WriteLine("Kladna postava bola ozdravena");

                    }
                    else
                    {
                        Console.WriteLine("Kladna uz nema manu a nebola ozdravena");
                    }




                }
                //Pokus o ozdravenie zapornej postavy a nasledny vipis ci sa to podarilo// 
                if (ZapornaPostava.HP <= 20)
                {
                    bool wasHealed = ZapornaPostava.Heal();
                    if (wasHealed)
                    {

                        Console.WriteLine("Zaporna postava bola ozdravena");

                    }
                    else
                    {
                        Console.WriteLine("Zaporna postava nema manu a nebola ozdravena");

                    }

                }

                Random random = new Random();
                int randomNumber = random.Next(0, 50);
                if (randomNumber <= 5)
                {
                    KladnaPostava.RefilMana(10);
                    Console.WriteLine("---Kladna postava dostala dar od Boha a doplnila sa jej mana---");
                }

              
                int randomNumber2 = random.Next(0, 50);
                if (randomNumber2 <= 5)
                {
                    ZapornaPostava.RefilMana(10);
                    Console.WriteLine("---Zaporna postava dostala dar od Boha a doplnila sa jej mana---");
                }












                if (ZapornaPostava.HP <= 0)
                {
                    Console.WriteLine("kladna postava vyhrala");
                    break;

                }

                if (KladnaPostava.HP <= 0)
                {
                    Console.WriteLine("Zaporna postava prehrala");
                    break;

                }




            }
        }
    }
}











