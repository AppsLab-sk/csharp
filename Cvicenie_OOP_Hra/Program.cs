namespace Cvicenie_OOP_Hra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Player player1 = new Player("Bača Jano", 20, 1500, 100, 5, 80);
            Player player2 = new Player("Zemepán Nikolaj Palfi", 20, 1600, 100, 5, 80);

            while (player2.HP >= 0 && player1.HP >= 0) 
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Player1 HP after Fight: " + player1.HP);
                Console.WriteLine("Player1 Hp after heal: " + player1.HP);
                if (player1.HP <= 20)
                {
                    bool isHeald = player1.Heal();
                    if (isHeald)
                    {
                        Console.WriteLine("Kladna postava bola uzdravena");
                    }
                    else
                    {
                        Console.WriteLine("Kladna postava uz nema manu");
                    }
                }
                Console.WriteLine("Player1 HP: " + player1.HP);
                player2.DamagePlayer(player1);


                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Player2 HP: " + player2.HP);
                player1.DamagePlayer(player2);
                if (player2.HP <= 20)
                { 
                        bool isHeald = player2.Heal();
                        if (isHeald)
                        {
                            Console.WriteLine("Zaporna postava bola uzdravena");
                        }
                        else
                        {
                            Console.WriteLine("Zaporna postava uz nema manu");
                        }
                }


                Console.WriteLine("Player2 HP after Fight: " + player2.HP);
                Console.WriteLine("Player2 Hp after heal: " + player2.HP);
            }
            if (player1.HP >= player2.HP)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Player1 is winner!");
            }
            else
            {
                ConsoleColor color = ConsoleColor.Blue;
                Console.WriteLine("Player2 is winner");
            }
        }
    }
}
