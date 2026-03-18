using System;
using System.Threading;

namespace Cvicenie_sims
{
    internal class Simsgame
    {
        public player myplayer { get; set; } = new player();

        public void StartGame()
        {
            bool running = true;
            int timer = 0;             // počítadlo času
            int interval = 3000;       // 3 sekundy
            int tick = 300;            // jeden cyklus menu = 300ms

            while (running)
            {
                Console.Clear();

                // ===================== ČASOVÁ SIMULÁCIA =====================
                timer += tick;
                if (timer >= interval)
                {
                    timer = 0; // resetujeme čas
                    myplayer.starving();
                    myplayer.thirsting();
                }

                // Ak hráč zomrie → stop
                if (myplayer.helth <= 0)
                {
                    Console.WriteLine("Tvoj Sim zomrel. GAME OVER.");
                    Console.WriteLine(myplayer.Status());
                    break;
                }

                // =========================== MENU ===========================
                Console.WriteLine("===== SIMS MENU =====");
                Console.WriteLine("1 - Pracovať (+20$)");
                Console.WriteLine("2 - Kúpiť jedlo (-10$)");
                Console.WriteLine("3 - Kúpiť vodu (-5$)");
                Console.WriteLine("4 - Zjesť jedlo");
                Console.WriteLine("5 - Napiť sa");
                Console.WriteLine("6 - Status");
                Console.WriteLine("0 - Koniec");
                Console.WriteLine();
                Console.WriteLine("Hlad: " + myplayer.hunger +
                                  " | Smäd: " + myplayer.thirst +
                                  " | Health: " + myplayer.helth);
                Console.Write("Vyber: ");

                if (Console.KeyAvailable)
                {
                    string choice = Console.ReadLine();
                    Console.Clear();

                    switch (choice)
                    {
                        case "1": Console.WriteLine(myplayer.Work()); break;
                        case "2": Console.WriteLine(myplayer.BuyFood()); break;
                        case "3": Console.WriteLine(myplayer.BuyWater()); break;
                        case "4": Console.WriteLine(myplayer.Eat()); break;
                        case "5": Console.WriteLine(myplayer.Drink()); break;
                        case "6": Console.WriteLine(myplayer.Status()); break;
                        case "0": running = false; continue;
                        default: Console.WriteLine("Neplatná možnosť."); break;
                    }
                }
               

                Thread.Sleep(tick); // 300ms cyklus
            }
        }
    }
}
