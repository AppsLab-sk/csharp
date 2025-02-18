namespace Cvicenie_OOP_Hra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player("Rytier", 150, 1500, 40, 50);
            Player player2 = new Player("Mag", 100, 1950, 60, 10);

            while (player2.HP >= 0 && player.HP >= 0)
            {
                Console.WriteLine("Player2 HP:" + player2.HP);
                player.DamagePlayer(player2);
                if (player.HP <= 20)
                {
                    bool wasHealed = player.Heal();
                    if (wasHealed)
                    {
                        Console.WriteLine("Zaporna postava bola uzdravena.");
                    }
                    else
                    {
                        Console.WriteLine("Zaporna postava uz nema manu");
                    }
                }

                Console.WriteLine("Player HP after Fight:" + player2.HP);
                Console.WriteLine("Player HP after Heal:" + player2.HP);

                Console.WriteLine("Player HP:" + player.HP);
                player2.DamagePlayer(player);
                Console.WriteLine("Player2 HP after Fight:" + player.HP);
                Console.WriteLine("Player2 HP after Heal:" + player.HP);
                if (player.HP <= 20)
                {
                    bool wasHealed = player.Heal();
                    if (wasHealed)
                    {
                        Console.WriteLine("Kladna postava bola uzdravena.");
                    }
                    else
                    {
                        Console.WriteLine("Kladna postava uz nema manu.");
                    }
                }
                Random random = new Random();
                int randomNumber = random.Next(0, 100);
                if (randomNumber <= 5) 
                {
                    player.RefilMana(10);
                    Console.WriteLine("Kladna postava dostala dar od boha a doplnila sa jej mana.");
                }
                
            }
            if(player.HP >= player2.HP)
            {
                Console.WriteLine("Player is winner!");
            }
            else
            {
                Console.WriteLine("Player2 is winner!");
            }

        }
    }
}