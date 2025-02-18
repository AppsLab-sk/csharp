using System.Diagnostics;
using System.Security.Cryptography;
using System.Threading;

namespace hadyARebriky
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Had> hadi = new List<Had>
               {
                new Had(17, 7),
                new Had(54, 34),
                new Had(42, 19),
                new Had(35, 24),
                new Had(10, 4),
                new Had(24, 15),
                };

            List<Rebrik> rebriky = new List<Rebrik>
                {
                 new Rebrik(3, 22),
                 new Rebrik(16, 35),
                 new Rebrik(28, 38),
                 new Rebrik(33, 46),
                 new Rebrik(49, 56),
                };





            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("$$\\   $$\\                 $$\\                                 $$$$$$$\\            $$\\                 $$\\ $$\\                 ");
            Console.WriteLine("$$ |  $$ |                $$ |                                $$  __$$\\           $$ |                \\__|$$ |                ");
            Console.WriteLine("$$ |  $$ | $$$$$$\\   $$$$$$$ |$$\\   $$\\        $$$$$$\\        $$ |  $$ | $$$$$$\\  $$$$$$$\\   $$$$$$\\  $$\\ $$ |  $$\\ $$\\   $$\\ ");
            Console.WriteLine("$$$$$$$$ | \\____$$\\ $$  __$$ |$$ |  $$ |       \\____$$\\       $$$$$$$  |$$  __$$\\ $$  __$$\\ $$  __$$\\ $$ |$$ | $$  |$$ |  $$ |");
            Console.WriteLine("$$  __$$ | $$$$$$$ |$$ /  $$ |$$ |  $$ |       $$$$$$$ |      $$  __$$< $$$$$$$$ |$$ |  $$ |$$ |  \\__|$$ |$$$$$$  / $$ |  $$ |");
            Console.WriteLine("$$ |  $$ |$$  __$$ |$$ |  $$ |$$ |  $$ |      $$  __$$ |      $$ |  $$ |$$   ____|$$ |  $$ |$$ |      $$ |$$  _$$<  $$ |  $$ |");
            Console.WriteLine("$$ |  $$ |\\$$$$$$$ |\\$$$$$$$ |\\$$$$$$$ |      \\$$$$$$$ |      $$ |  $$ |\\$$$$$$$\\ $$$$$$$  |$$ |      $$ |$$ | \\$$\\ \\$$$$$$$ |");
            Console.WriteLine("\\__|  \\__| \\_______| \\_______| \\____$$ |       \\_______|      \\__|  \\__| \\_______|\\_______/ \\__|      \\__|\\__|  \\__| \\____$$ |");
            Console.WriteLine("                              $$\\   $$ |                                                                            $$\\   $$ |");
            Console.WriteLine("                              \\$$$$$$  |                                                                            \\$$$$$$  |");
            Console.WriteLine("                               \\______/                                                                              \\______/ ");
            Console.WriteLine();
            Thread.Sleep(2000);
            Console.WriteLine("Ak chceš začať hrať hru stlač tlačidlo ENTER");
            Thread.Sleep(1000);
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Vyber možnosť:");
            Console.WriteLine("Stlač číslo 1, ak chceš vedieť informácie o tom, kto vytvoril túto hru.");
            Console.WriteLine("Stlač číslo 2, ak chceš vedieť pravidlá tejto hry.");
            Console.WriteLine("Stlač číslo 3, ak chceš napísať recenziu alebo dať nápad na vylepšenie.");
            Console.WriteLine("Stlač číslo 4, ak chceš začať hrať hru.");


            bool running = true;
            while (running)
            {


                var choice = Console.ReadLine();


                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Možno sa pýtate. Kto je za touto hrou? Radi by sme sa vám predstavili a povedali par veci o nás");
                        Thread.Sleep(1000);
                        Console.WriteLine("Volám sa Branislav Sventek. Narodil som sa v Čadci presnejšie na Horelici, kde doteraz žijem.");
                        Console.WriteLine("Mám rád hudbu najobľúbenejší žáner R&B. Rad pozerám filmy každého druhu a najradšej trávim čas s ľuďmi, ktorých mam rád. ");
                        Thread.Sleep(3500);
                        Console.WriteLine("Volám sa Alica Laštíková bývam v Tepličke nad Váhom 15 rokov vo voľnom čase rada pozerám seriály s rôznou tematikou napríklad akčné, dráma, anime, sci-fi atď.");
                        Console.WriteLine("Milujem mačičky a baví ma dizajn a architektúra ale nechcem sa tomu venovať možno uvidím rada trávím čas so svojimi kamarátmi.");
                        Thread.Sleep(3500);
                        Console.WriteLine("Teraz sme žiaci na SPŠ IT v KNM.");
                        Thread.Sleep(500);
                        Console.WriteLine("Tento projekt nám dal veľa námahy a úsilia ale hlavne veľa skúsenosti tak hádam sa vám bude páčiť :)");
                        Thread.Sleep(1000);
                        break;


                    case "2":
                        Console.WriteLine("Pravidlá hry sú jednoduché:");
                        Thread.Sleep(1000);
                        Console.WriteLine("Hodíš kockou a posunieš sa na dané políčko.");
                        Thread.Sleep(1000);
                        Console.WriteLine("Ak sa na poličku nachádza rebrík posunieš sa na poličko kde rebrík končí.");
                        Thread.Sleep(1000);
                        Console.WriteLine("Ak sa nachádzaš na políčku, kde je hadia hlava.");
                        Thread.Sleep(1000);
                        Console.WriteLine("Tak sa až na hodov chvost. ");
                        Thread.Sleep(1000);
                        Console.WriteLine("Kdo bode prvý v cieli hrava.");
                        Thread.Sleep(1000);
                        Console.WriteLine("Ak pravidla neboli jasné tak nam dajte vedieť na naš email. :))");
                        Thread.Sleep(1000);
                        Console.WriteLine("Prajeme vela zabavý a hlavne šťastia.");
                        Thread.Sleep(1000);
                        break;


                    case "3":
                        Console.WriteLine("Môžete nám napísať, ako sa vám hra páči a čo by ste na to vylepšili, na email branislaw3@gmail.com alebo alicalastikova12@gmail.com .");
                        Thread.Sleep(100);
                        break;

                    case "4":

                        {
                            Kocka kocka = new Kocka();
                            Hrac hrac1 = new Hrac("Hráč 1");
                            Hrac hrac2 = new Hrac("Hráč 2");
                            int aktualnyHrac = 1;
                            while (true)

                            {
                                if (aktualnyHrac == 1)
                                {
                                    Console.WriteLine("Hráč 1 hodí kockou:");
                                    Console.ReadLine();
                                    int hod1 = kocka.Hod();
                                    hrac1.Pozicia += hod1;
                                    Console.WriteLine($"{hrac1.Meno} hodil: {hod1} (Skóre: {hrac1.Pozicia})");

                                    aktualnyHrac = 2;
                                    var had = hadi.FirstOrDefault(h => h.Start == hrac1.Pozicia);
                                    if (had != null)
                                    {
                                        hrac1.Pozicia = had.End;

                                        Console.WriteLine($"Ooohhh nie aka škoda {hrac1.Meno} klesá z {had.Start} na {had.End} kvôli hadovi!");




                                    }

                                    var rebrik = rebriky.FirstOrDefault(r => r.Start == hrac1.Pozicia);
                                    if (rebrik != null)
                                    {
                                        hrac1.Pozicia = rebrik.End;
                                        Console.WriteLine($"Super {hrac1.Meno} stúpa z {rebrik.Start} na {rebrik.End} pomocou rebríku!");


                                    }

                                    Console.WriteLine($"{hrac1.Meno} je teraz na pozícií {hrac1.Pozicia}");

                                    if (hrac1.Pozicia == 60)
                                    {
                                        Console.WriteLine($"Blahoželam {hrac1.Meno} vyhral hru! :)");
                                        Console.WriteLine("$$\\    $$\\ $$\\     $$\\ $$\\   $$\\ $$$$$$$\\   $$$$$$\\  $$\\              $$$$$$\\  $$$$$$\\ ");
                                        Console.WriteLine("$$ |   $$ |\\$$\\   $$  |$$ |  $$ |$$  __$$\\ $$  __$$\\ $$ |            $$  __$$\\ \\_$$  _|");
                                        Console.WriteLine("$$ |   $$ | \\$$\\ $$  / $$ |  $$ |$$ |  $$ |$$ /  $$ |$$ |            $$ /  \\__|  $$ |  ");
                                        Console.WriteLine("\\$$\\  $$  |  \\$$$$  /  $$$$$$$$ |$$$$$$$  |$$$$$$$$ |$$ |            \\$$$$$$\\    $$ |  ");
                                        Console.WriteLine(" \\$$\\$$  /    \\$$  /   $$  __$$ |$$  __$$< $$  __$$ |$$ |             \\____$$\\   $$ |  ");
                                        Console.WriteLine("  \\$$$  /      $$ |    $$ |  $$ |$$ |  $$ |$$ |  $$ |$$ |            $$\\   $$ |  $$ |  ");
                                        Console.WriteLine("   \\$  /       $$ |    $$ |  $$ |$$ |  $$ |$$ |  $$ |$$$$$$$$\\       \\$$$$$$  |$$$$$$\\ ");
                                        Console.WriteLine("    \\_/        \\__|    \\__|  \\__|\\__|  \\__|\\__|  \\__|\\________|       \\______/ \\______|");


                                        break;
                                    }
                                    if (hrac1.Pozicia > 60)
                                    {
                                        hrac1.Pozicia -= hod1;
                                        Console.WriteLine($"Bohužial {hrac1.Meno} nemôže ísť ďalej. Hracie pole už ďalej nepokračuje. Hrač sa nachádza {hrac1.Pozicia}  ");

                                    }
                                }

                                if (aktualnyHrac == 2)
                                {

                                    Console.WriteLine("Hráč 2 hodí kockou:");
                                    Console.ReadLine();
                                    int hod2 = kocka.Hod();
                                    hrac2.Pozicia += hod2;
                                    Console.WriteLine($"{hrac2.Meno} hodil: {hod2} (Skóre: {hrac2.Pozicia})");

                                    aktualnyHrac = 1;
                                    var had1 = hadi.FirstOrDefault(h => h.Start == hrac2.Pozicia);
                                    if (had1 != null)
                                    {
                                        hrac2.Pozicia = had1.End;
 
                                        Console.WriteLine($"Ooohhh nie aká škoda {hrac2.Meno} klesá z {had1.Start} na {had1.End} kvôli hadovi!");

                                       



                                    }

                                    var rebrik1 = rebriky.FirstOrDefault(r => r.Start == hrac2.Pozicia);
                                    if (rebrik1 != null)

                                        Console.WriteLine($"{hrac2.Meno} je teraz na pozícii {hrac2.Pozicia}");

                                    if (hrac2.Pozicia == 60)
                                    {
                                        Console.WriteLine($"Blahoželam {hrac2.Meno} vyhral hru! :)");
                                        Console.WriteLine("$$\\    $$\\ $$\\     $$\\ $$\\   $$\\ $$$$$$$\\   $$$$$$\\  $$\\              $$$$$$\\  $$$$$$\\ ");
                                        Console.WriteLine("$$ |   $$ |\\$$\\   $$  |$$ |  $$ |$$  __$$\\ $$  __$$\\ $$ |            $$  __$$\\ \\_$$  _|");
                                        Console.WriteLine("$$ |   $$ | \\$$\\ $$  / $$ |  $$ |$$ |  $$ |$$ /  $$ |$$ |            $$ /  \\__|  $$ |  ");
                                        Console.WriteLine("\\$$\\  $$  |  \\$$$$  /  $$$$$$$$ |$$$$$$$  |$$$$$$$$ |$$ |            \\$$$$$$\\    $$ |  ");
                                        Console.WriteLine(" \\$$\\$$  /    \\$$  /   $$  __$$ |$$  __$$< $$  __$$ |$$ |             \\____$$\\   $$ |  ");
                                        Console.WriteLine("  \\$$$  /      $$ |    $$ |  $$ |$$ |  $$ |$$ |  $$ |$$ |            $$\\   $$ |  $$ |  ");
                                        Console.WriteLine("   \\$  /       $$ |    $$ |  $$ |$$ |  $$ |$$ |  $$ |$$$$$$$$\\       \\$$$$$$  |$$$$$$\\ ");
                                        Console.WriteLine("    \\_/        \\__|    \\__|  \\__|\\__|  \\__|\\__|  \\__|\\________|       \\______/ \\______|");



                                        break;
                                    }
                                    if (hrac2.Pozicia > 60)
                                    {
                                        hrac2.Pozicia -= hod2;
                                        Console.WriteLine($"Bohuzial {hrac2.Meno} nemôže ísť ďalej. Hracie pole už ďalej nepokračuje. Hrač sa nachádza {hrac2.Pozicia}  ");

                                    }


                                }


                            }













                        }
                        break;


                }
            }
        }
    }
}

     


