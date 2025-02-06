namespace Cvicenie_OPP_Hra;

internal class Program
{
    static void Main(string[] args)
    {
        Hra kladnapostava = new Hra() { PlayerName = "ArthurMorgan", Power = 30, HP = 1000, Mana = 50, CritChance = 50 };
        Hra zapornapostava = new Hra() { PlayerName = "MicahBell", Power = 30, HP = 1050, Mana = 50, CritChance = 10 };

        Console.WriteLine("Zaporna postava HP:" + zapornapostava.HP);
        kladnapostava.Damage(zapornapostava);
        Console.WriteLine("Zaporna postava HP:" + zapornapostava.HP);


        while (kladnapostava.HP >= 0 && zapornapostava.HP >= 0)
        {
            Console.WriteLine("Kladna Postava HP:" + kladnapostava.HP);
            Console.WriteLine("Zaporna Postava HP" + zapornapostava.HP);
            kladnapostava.Damage(zapornapostava);
            zapornapostava.Damage(kladnapostava);

            if (kladnapostava.HP <= 20)
            {
                bool washealed = kladnapostava.heal();
                if (washealed)
                {
                    Console.WriteLine("Kladna postava bola oydravena");
                }
                else
                {
                    Console.WriteLine("Kladna postava nema dostatok many");
                }

                //pouzitie many ZP
            }
            if (zapornapostava.HP <= 20)
            {
                bool wasHealed = zapornapostava.heal();
                if (wasHealed)
                {
                    Console.WriteLine("Zaporna postava bola oydravena");
                }
                else
                {
                    Console.WriteLine("Zaporna postava nema dostatok many");
                }


            }
            //end

            Random random = new Random();
            int randomnumber = random.Next(0, 100);
            if (randomnumber <= 5)
            {
                kladnapostava.RefilMana(50);
                Console.WriteLine("-----Arthur was given the gift of god-----");
            }

            int randomnumber2 = random.Next(0, 100);
            if (randomnumber2 <= 10)
            {
                zapornapostava.RefilMana(50);
                Console.WriteLine("-----Micah was given the gift of god------");
            }


        }
        if (kladnapostava.HP < 0)
        {
            Console.WriteLine("Magician wins !");
        }
        if (zapornapostava.HP < 0)

        {
            Console.WriteLine("Wizard wins !");

        }

    }

}
        




