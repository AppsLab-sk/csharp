namespace Cvicenie_OOP_grapocitacowa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Polski Simulator Gry Pocitacowei";
            //Hraci (Class, Power, HP, Mana, Kritical, RefilChanceMana)
            Player player1 = new Player("Bača Jano", 10, 200, 60, 50, 80); 
            Player player2 = new Player("Zemepán Nikolaj Palfi", 10, 250, 40, 10, 80);  

            //Suboj medzi hracmi
            while (player2.HP >= 0 && player1.HP >= 0)
            {
                //Player1 utoci
                Console.WriteLine("Player2 HP: " + player2.HP);
                player1.DamagePlayer(player2);
                Console.WriteLine("Player2 HP after Fight: " + player2.HP);
                if (player2.HP <= 20) //Player2 sa healuje
                {
                    bool isHealed = player2.HealPlayer();
                    if (isHealed)
                    {
                        Console.WriteLine("Player2 was healed!");
                    }
                    else
                    {
                        Console.WriteLine("Player2 doesn't have any mana left!");
                    }
                }
                Thread.Sleep(0100);

                //Player2 utoci
                Console.WriteLine("Player1 HP: " + player1.HP);
                player2.DamagePlayer(player1);
                Console.WriteLine("Player1 HP after Fight: " + player1.HP);
                if (player1.HP <= 20) //Player1 sa healuje
                {
                    bool isHealed = player1.HealPlayer();
                    if (isHealed)
                    {
                        Console.WriteLine("Player1 was healed!");
                    }
                    else
                    {
                        Console.WriteLine("Player1 doesn't have any mana left!");
                    }
                }
                Thread.Sleep(0100);

              
                
            }

            //Vitaz bitky
            if (player1.HP > player2.HP)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Player1 {player1.ClassType} is winner!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Player2 {player2.ClassType} is winner!");
            }
            
        }
    }
}