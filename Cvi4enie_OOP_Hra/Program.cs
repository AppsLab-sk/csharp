using System.Diagnostics.SymbolStore;

namespace Cvi4enie_OOP_Hra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            {
                player.Name = "B";
                player.HP = 100;
                player.Mana = 8;
                player.AttackPower = 6;
                player.Critchange = 5;
            }
            Player player2 = new Player();
            {
                player2.Name = "H";
                player2.HP = 100;
                player2.Mana = 15;
                player2.AttackPower = 3;
                player2.Critchange = 4;
            }

            while (player.HP >= 0 && player2.HP >= 0)
                while (player.HP >= 0 && player2.HP >= 0)
                {
                    Console.WriteLine("player:" + player.HP);
                    Console.WriteLine("player2:" + player.HP);
                    player.DamagePlayer(player2);
                    player2.DamagePlayer(player);

                    if (player.HP <= 20)
                    {
                        bool wasHealed = player.Heal();
                        if (wasHealed)
                        {
                            Console.WriteLine("player postava bola uzdravena.");
                        }
                        else
                        {
                            Console.WriteLine("player nema manu nebola uzdravena.");
                        }
                       
                    }
                    if (player2.HP <= 20)
                    {
                        bool wasHealed = player2.Heal();
                        if (wasHealed)
                        {
                            Console.WriteLine("player2 postava bola uzdravena.");
                        }
                        else
                        {
                            Console.WriteLine("player2 nema manu nebola uzdravena.");
                        }

                    }
               
                    Random random = new Random();
                    int randomNumber = random.Next(0, 100);
                    if (randomNumber <= 5)
                    {
                        player.RefilMana(10);
                        Console.WriteLine("mana bola dobita");
                    }

                    {

                        Random random1 = new Random();
                        int Number = random1.Next(0, 100);
                        if (Number <= 5)
                        {
                            player.RefilMana(10);
                            Console.WriteLine("mana bola dobita");
                        }
                    }

                }
        }
    }
}