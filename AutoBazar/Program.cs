

using System;
using System.Text.Json;


namespace AutoBazar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Garaze garaze = new Garaze();
            Garaze gara = new Garaze();
            List<int> list = new List<int>();
            Auto kia = new Auto(1, "Kia", "Ceed", 8000, 5, 5, 7, "je vo velmi dobrom stave neporusena");
            Auto toyota = new Auto(2, "Toyota", "Corolla", 15000, 8, 7, 9, "je skoro neposkodena ako nova dobra kvalita");
            Auto VLKW = new Auto(3, "Volkswagen", "Golf", 3500, 4, 4, 3, "Auto je trochu oskrete s bokou a brzdy sa prehrievaju");
            Auto Ford = new Auto(4, "Ford", "Fiesta", 5675, 4, 5, 7, "je v dobrom stave a ma najazdne 15 000 km ");
            Auto Mercedez = new Auto(5, "Mercedes-Benz ", "A-Class", 9500, 5, 5, 7, "je vo velmi dobrom stave neporusena a ma na kufri originalny podpis Fuck Shita a Lewis Hamiltona");
            Auto Audi = new Auto(6, "Audi", "A6", 8573, 5, 5, 7, "je vo velmi dobrom stave neporusena a s tuningom podlahy a vyfuku");
            Auto honda = new Auto(7, "Honda", "Civic", 10000, 5, 5, 410, "je vo velmi dobrom stave neporusena");
            Auto dodge = new Auto(8, "Dodge", "Challenger STR Hellcat ", 103563, 18, 2, 458, "auto je nové, v základe vybavené s twin turbom");
            Auto mazda = new Auto(9, "Mazda", "MX 5", 5000, 7, 2, 130, "Auto bolo jazdené YouTuberom CarMightyVids");
            Auto subaru = new Auto(10, "Subaru", "Impreza", 12000, 6, 5, 385, "v aute bolo jazdené rallye, má vylepšené odpruženie + twin trubo");
            Auto mitsubishi = new Auto(11, "Mitsubishi", "Lancer Evo 9", 40000, 8, 5, 430, "auto má pokrčený zadný nárazník");
            Auto lexus = new Auto(12, "Lexus", "LS600HL President", 15000, 9, 4, 420, "auto v dobrom stave,´najazdené 240xxx KM");
            Auto nissan = new Auto(13, "Nissan", "Skyline GTR R34", 50000, 10, 2, 400, "auto je vo výbornom stave, má novú keramickú ochranu laku a originálne disky NISMO");
            Auto ferrari = new Auto(14, "Ferrari", "488 Pista", 300000, 14, 2, 270, "limitovaná edícia v červenej farbe Rosso Corsa, vhodné pre zberateľov");
            Auto chevrolet = new Auto(15, "Chevrolet", "Camaro ZL1", 65000, 12, 4, 550, "svalnaté americké auto s vylepšeným výfukovým systémom Borla");
            Auto porsche = new Auto(16, "Porsche", "911 Turbo S", 200000, 13, 2, 310, "luxusné športové auto s vynikajúcou dynamikou a nový infotainment systém");
            Auto jaguar = new Auto(17, "Jaguar", "F-Type R", 85000, 11, 2, 400, "moderný dizajn, zlaté brzdy a špičkový kožený interiér s ručným prešívaním");
            Auto tesla = new Auto(18, "Tesla", "Model S Plaid", 130000, 16, 5, 800, "elektrické auto s rekordnou akceleráciou a dojazdom 600 km");
            Auto lamborghini = new Auto(19, "Lamborghini", "Huracán EVO", 250000, 12, 2, 310, "exotické talianske superauto s agresívnym dizajnom a aerodynamickými prvkami");
            Auto alfaRomeo = new Auto(20, "Alfa Romeo", "Giulia Quadrifoglio", 75000, 9, 5, 480, "luxusný sedan s pretekárskou DNA a jedinečným talianskym šarmom");
            Auto bugatti = new Auto(21, "Bugatti", "Chiron", 3000000, 25, 2, 1800, "ultra-luxusné hyperauto s najvyššou rýchlosťou cez 400 km/h a jedinečným interiérom z uhlíkových vlákien");


            //Auta v garazi 
            garaze.PridajAuto(kia);
            garaze.PridajAuto(toyota);
            garaze.PridajAuto(VLKW);
            garaze.PridajAuto(Ford);
            garaze.PridajAuto(Mercedez);
            garaze.PridajAuto(Audi);
            garaze.PridajAuto(honda);
            garaze.PridajAuto(dodge);
            garaze.PridajAuto(mazda);
            garaze.PridajAuto(subaru);
            garaze.PridajAuto(mitsubishi);
            garaze.PridajAuto(lexus);
            garaze.PridajAuto(nissan);
            garaze.PridajAuto(ferrari);
            garaze.PridajAuto(chevrolet);
            garaze.PridajAuto(porsche);
            garaze.PridajAuto(jaguar);
            garaze.PridajAuto(tesla);
            garaze.PridajAuto(lamborghini);
            garaze.PridajAuto(alfaRomeo);
            garaze.PridajAuto(bugatti);

            bool isEnd = false;

            while (!isEnd) // Prihlasenie sa do Adminu, Hostu alebo Developeru
            {
                Menu();
                Console.Write("Zadaj Prihlasovacie meno: ");
                var zadavaniemena = Console.ReadLine();
                Console.WriteLine("  ");
                Console.Write("Zadaj Heslo: ");
                var zadaniehesla = Console.ReadLine();
                Console.WriteLine("  ");

                //Hesla
                var host = "Host";
                var hheslo = "Host";
                var admin = "Admin";
                var aheslo = "Admin";
                var dev = "Dev";
                var dheslo = "Dev";

                if (host == zadavaniemena && hheslo == zadaniehesla) //Host ucet
                {
                    Console.WriteLine("Vitaj Host");
                    while (true)
                    {
                        Host();
                        var akio = Console.ReadLine();

                        if (akio == "5") //Odhlasovacia sranda
                        {
                            Console.WriteLine("Odhlasujem z uctu");
                            Thread.Sleep(1500);
                            Console.Clear();
                            break;
                        }
                        switch (akio)
                        {
                            case "1": // Prezeranie Aut

                                Console.Clear();
                                Menu();

                                garaze.VypisVsetkyAuta();
                                Console.WriteLine("  ");
                                Console.WriteLine("[][][][][][][][][][][][][][][][][  ");
                                Console.WriteLine("1. Pridat Auto medzi oblubene  ");
                                Console.WriteLine("2. Vratit sa na Hlavnu ponuku  ");
                                Console.WriteLine(" ");
                                Console.Write("Vyberte funkciu: ");
                                var dhcp = Console.ReadLine();
                                switch (dhcp)
                                {
                                    case "1":
                                        Console.Write("Zadajte index auta na Pridanie medzi oblubene: ");
                                        int.TryParse(Console.ReadLine(), out int indexOblu);
                                        garaze.PridajOblubene(indexOblu);
                                        break;
                                    case "2":
                                        Console.WriteLine("  ");
                                        Console.WriteLine("Vraciam na Hlavnu ponuku  ");
                                        Console.WriteLine("Bude chvilu trvat");
                                        Thread.Sleep(1000);
                                        break;
                                }
                                break;

                            case "2": //Oblubene Auta
                                Console.Clear();
                                Menu();
                                if (garaze.Oblubeny.Count == 0)
                                {
                                    Console.WriteLine("Nemas oblubene auta musis ich pridat");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Tvoje oblubene auta");
                                    garaze.VypisOblubene();
                                    Console.WriteLine("  ");

                                    Console.Write("Pre vratenie sa na hlavnu ponuku stlacte Enter: ");
                                    var dhcpo = Console.ReadLine();
                                    switch (dhcpo)
                                    {
                                        case " ":

                                            break;

                                    }
                                    break;
                                }
                            case "3": //Kupovanie Auta
                                Console.Clear();
                                Menu();
                                Console.WriteLine("1. Prezeranie vsetkych Aut");
                                Console.WriteLine("2. Prezeranie oblubenych Aut");
                                Console.WriteLine(" ");
                                Console.Write("Vyberte z kadial chcete auta kupovat: ");
                                var dhcpu = Console.ReadLine();
                                switch (dhcpu)
                                {
                                    case "1":
                                        Console.Clear();
                                        Menu();
                                        garaze.VypisVsetkyAuta();
                                        Console.WriteLine();

                                        Console.Write("Vyber Auto na kupovania: ");
                                        int indexAuta = int.Parse(Console.ReadLine());
                                        garaze.VypocitajCenuPredaju(indexAuta);
                                        garaze.OdstranjAuto(indexAuta);
                                        Thread.Sleep(1000);
                                        Console.Clear();
                                        break;

                                    case "2":
                                        Console.Clear();
                                        Menu();
                                        garaze.VypisOblubene();

                                        if (garaze.Oblubeny.Count == 0)
                                        {
                                            Console.WriteLine("Nemas oblubene auta musis ich pridat");
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Vyber Auto na kupovania:");
                                            int indexoblu = int.Parse(Console.ReadLine());
                                            garaze.VypocitajCenuPredaju(indexoblu);
                                            garaze.OdstranjOblubeneAuto(indexoblu);
                                            garaze.OdstranjAuto(indexoblu);
                                            Thread.Sleep(1000);
                                            Console.Clear();
                                        }
                                        break;
                                }

                                //Vypocitanie ceny
                                break;

                            case "4": //Harakiri aplikacie
                                isEnd = true;
                                Console.WriteLine("");
                                Console.WriteLine("Dakujeme za pouzivanie applikacie. Dufam za sa vratite");
                                return;

                        }
                    }
                }
                else if (admin == zadavaniemena && aheslo == zadaniehesla) // Admin ucet
                {
                    Console.WriteLine("Vitaj Admin");
                    while (true)
                    {
                        Admin();
                        var akia = Console.ReadLine();

                        if (akia == "5") //Odhlasovacia sranda
                        {
                            Console.WriteLine("Odhlasujem z uctu");
                            Thread.Sleep(1500);
                            Console.Clear();
                            break;
                        }

                        switch (akia)
                        {
                            case "1": // pridavanie Aut
                                Console.Clear();
                                Menu();
                                Console.Write("Zadaj Prihlasovacie meno: ");
                                var zadavaniemena1 = Console.ReadLine();
                                Console.WriteLine("  ");
                                Console.Write("Zadaj Heslo: ");
                                var zadaniehesla1 = Console.ReadLine();
                                Console.WriteLine("  ");

                                var meno = "Jan";
                                var men0 = "Jakub";
                                var heslo = "Heslo123";
                                var hesl0 = "HesloHeslo";
                                var menosecret = "Mato";
                                var heslosecret = "Automaty<3";

                                if (zadavaniemena1 == meno && zadaniehesla1 == heslo)
                                {
                                    Console.Clear();
                                    Menu();

                                }
                                else if (zadavaniemena == men0 && zadaniehesla == hesl0)
                                {
                                    Console.Clear();
                                    Menu();

                                }
                                else if (zadavaniemena == menosecret && zadaniehesla == heslosecret)
                                {
                                    Console.Clear();
                                    Menu();

                                }
                                else
                                {
                                    Console.WriteLine("Nespravne meno alebo heslo");
                                    break;
                                }
                                Console.WriteLine("Zadajte značku auta:");
                                var znacka = Console.ReadLine();
                                Console.WriteLine("----------------------------------------- ");
                                Console.WriteLine("Zadajte model auta:");
                                var model = Console.ReadLine();
                                Console.WriteLine("----------------------------------------- ");
                                Console.WriteLine("Zadajte cenu auta:");
                                var cena = int.Parse(Console.ReadLine());
                                Console.WriteLine("----------------------------------------- ");
                                Console.WriteLine("Zadajte spotrebu auta:");
                                var spotreba = int.Parse(Console.ReadLine());
                                Console.WriteLine("----------------------------------------- ");
                                Console.WriteLine("Zadajte počet pasažierov:");
                                var pasazieri = int.Parse(Console.ReadLine());
                                Console.WriteLine("----------------------------------------- ");
                                Console.WriteLine("Zadajte objem batožinového priestoru:");
                                var batozina = int.Parse(Console.ReadLine());
                                Console.WriteLine("----------------------------------------- ");
                                Console.WriteLine("Zadajte opis auta:");
                                var opis = Console.ReadLine();

                                int indexauta = garaze.ZoznamAut.Count() + 1;
                                Auto noveAuto = new Auto(indexauta, znacka, model, cena, spotreba, pasazieri, batozina, opis);
                                garaze.PridajAuto(noveAuto);
                                Console.WriteLine(" ");
                                Console.WriteLine($"Auto znacky {znacka}  {model} za {cena}$. Ma spotrebu {spotreba} a velkost batozinoveho priestoru je {batozina} L. Pocet pasazierov je {pasazieri} a Opis: {opis}");
                                Thread.Sleep(2000);
                                break;

                            case "2": // Prezeranie Aut

                                Console.Clear();
                                Menu();

                                garaze.VypisVsetkyAuta();
                                Console.WriteLine("  ");
                                Console.WriteLine("[][][][][][][][][][][][][][][][][  ");
                                Console.WriteLine("1. Pridat Auto medzi oblubene  ");
                                Console.WriteLine("2. Vratit sa na Hlavnu ponuku  ");
                                Console.WriteLine(" ");
                                Console.Write("Vyberte funkciu: ");
                                var dhcp = Console.ReadLine();
                                switch (dhcp)
                                {
                                    case "1":
                                        Console.Write("Zadajte index auta na Pridanie medzi oblubene: ");
                                        int.TryParse(Console.ReadLine(), out int indexOblu);
                                        garaze.PridajOblubene(indexOblu);
                                        break;
                                    case "2":
                                        Console.WriteLine("  ");
                                        Console.WriteLine("Vraciam na Hlavnu ponuku  ");
                                        Console.WriteLine("Bude chvilu trvat");
                                        Thread.Sleep(1000);
                                        break;
                                }
                                break;

                            case "3": //Oblubene Auta
                                Console.Clear();
                                Menu();
                                if (garaze.Oblubeny.Count == 0)
                                {
                                    Console.WriteLine("Nemas oblubene auta musis ich pridat");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Tvoje oblubene auta");
                                    garaze.VypisOblubene();
                                    Console.WriteLine("  ");

                                    Console.Write("Pre vratenie sa na hlavnu ponuku stlacte Enter: ");
                                    var dhcpo = Console.ReadLine();
                                    switch (dhcpo)
                                    {
                                        case " ":

                                            break;

                                    }
                                    break;
                                }
                            case "4": //Harakiri aplikacie
                                isEnd = true;
                                Console.WriteLine("");
                                Console.WriteLine("Dakujeme za pouzivanie applikacie. Dufam za sa vratite");
                                return;

                            case "6":
                                Console.Clear();
                                Menu();
                                Console.Write("Zadaj Prihlasovacie meno: ");
                                var zadavaniemena12 = Console.ReadLine();
                                Console.WriteLine("  ");
                                Console.Write("Zadaj Heslo: ");
                                var zadaniehesla12 = Console.ReadLine();
                                Console.WriteLine("  ");

                                var meno1 = "Jan";
                                var men01 = "Jakub";
                                var heslo1 = "Heslo123";
                                var hesl01 = "HesloHeslo";
                                var menosecret1 = "Mato";
                                var heslosecret1 = "Automaty<3";

                                if (zadavaniemena12 == meno1 && zadaniehesla12 == heslo1)
                                {
                                    Console.Clear();
                                    Menu();

                                }
                                else if (zadavaniemena12 == men01 && zadaniehesla12 == hesl01)
                                {
                                    Console.Clear();
                                    Menu();

                                }
                                else if (zadavaniemena12 == menosecret1 && zadaniehesla12 == heslosecret1)
                                {
                                    Console.Clear();
                                    Menu();

                                }
                                else
                                {
                                    Console.WriteLine("Nespravne meno alebo heslo");
                                    break;
                                }
                                Console.Clear();
                                Menu();
                                garaze.VypisVsetkyAuta();
                                Console.WriteLine();

                                Console.Write("Vyber Auto na Odtranenie: ");
                                int indexAuta = int.Parse(Console.ReadLine());
                                garaze.OdstranjAuto(indexAuta);
                                Thread.Sleep(1000);
                                Console.Clear();
                                break;
                        }
                    }
                }
                else if (dev == zadavaniemena && dheslo == zadaniehesla)   // Developer ucet
                {
                    Console.WriteLine("Vitaj Developer");
                    while (!isEnd)
                    {
                        VypisInfo();
                        var akcio = Console.ReadLine();

                        if (akcio == "6") //Odhlasovacia sranda
                        {
                            Console.WriteLine("Odhlasujem z uctu");
                            Thread.Sleep(1500);
                            Console.Clear();
                            break;
                        }

                        switch (akcio)
                        {
                            case "1": // pridavanie Aut
                                Console.Clear();
                                Menu();
                                Console.Write("Zadaj Prihlasovacie meno: ");
                                var zadavaniemena1 = Console.ReadLine();
                                Console.WriteLine("  ");
                                Console.Write("Zadaj Heslo: ");
                                var zadaniehesla1 = Console.ReadLine();
                                Console.WriteLine("  ");

                                var meno = "Jan";
                                var men0 = "Jakub";
                                var heslo = "Heslo123";
                                var hesl0 = "HesloHeslo";
                                var menosecret = "Mato";
                                var heslosecret = "Automaty<3";

                                if (zadavaniemena1 == meno && zadaniehesla1 == heslo)
                                {
                                    Console.Clear();
                                    Menu();

                                }
                                else if (zadavaniemena == men0 && zadaniehesla == hesl0)
                                {
                                    Console.Clear();
                                    Menu();

                                }
                                else if (zadavaniemena == menosecret && zadaniehesla == heslosecret)
                                {
                                    Console.Clear();
                                    Menu();

                                }
                                else
                                {
                                    Console.WriteLine("Nespravne meno alebo heslo");
                                    break;
                                }
                                Console.WriteLine("Zadajte značku auta:");
                                string znacka = Console.ReadLine();
                                Console.WriteLine("----------------------------------------- ");
                                Console.WriteLine("Zadajte model auta:");
                                string model = Console.ReadLine();
                                Console.WriteLine("----------------------------------------- ");
                                Console.WriteLine("Zadajte cenu auta:");
                                int cena = int.Parse(Console.ReadLine());
                                Console.WriteLine("----------------------------------------- ");
                                Console.WriteLine("Zadajte spotrebu auta:");
                                int spotreba = int.Parse(Console.ReadLine());
                                Console.WriteLine("----------------------------------------- ");
                                Console.WriteLine("Zadajte počet pasažierov:");
                                int pasazieri = int.Parse(Console.ReadLine());
                                Console.WriteLine("----------------------------------------- ");
                                Console.WriteLine("Zadajte objem batožinového priestoru:");
                                int batozina = int.Parse(Console.ReadLine());
                                Console.WriteLine("----------------------------------------- ");
                                Console.WriteLine("Zadajte opis auta:");
                                string opis = Console.ReadLine();

                                int indexauta = garaze.ZoznamAut.Count() + 1;
                                Auto noveAuto = new Auto(indexauta, znacka, model, cena, spotreba, pasazieri, batozina, opis);
                                garaze.PridajAuto(noveAuto);
                                //string json = JsonSerializer.Serialize(garaze);
                                //File.WriteAllText(@"D:\path.json", json);
                                Console.WriteLine($"Auto znacky {znacka}  {model} za {cena}$. Ma spotrebu {spotreba} a velkost batozinoveho priestoru je {batozina} L. Pocet pasazierov je {pasazieri} a Opis: {opis}");
                                Thread.Sleep(2000);
                                break;

                            case "2": // Prezeranie Aut

                                Console.Clear();
                                Menu();

                                garaze.VypisVsetkyAuta();
                                Console.WriteLine("  ");
                                Console.WriteLine("[][][][][][][][][][][][][][][][][  ");
                                Console.WriteLine("1. Pridat Auto medzi oblubene  ");
                                Console.WriteLine("2. Vratit sa na Hlavnu ponuku  ");
                                Console.WriteLine(" ");
                                Console.Write("Vyberte funkciu: ");
                                var dhcp = Console.ReadLine();
                                switch (dhcp)
                                {
                                    case "1":
                                        Console.Write("Zadajte index auta na Pridanie medzi oblubene: ");
                                        int.TryParse(Console.ReadLine(), out int indexOblu);
                                        garaze.PridajOblubene(indexOblu);
                                        break;
                                    case "2":
                                        Console.WriteLine("  ");
                                        Console.WriteLine("Vraciam na Hlavnu ponuku  ");
                                        Console.WriteLine("Bude chvilu trvat");
                                        Thread.Sleep(1000);
                                        break;
                                }
                                break;

                            case "3": //Oblubene Auta
                                Console.Clear();
                                Menu();
                                Console.WriteLine("Tvoje oblubene auta");
                                Console.WriteLine("  ");
                                if (garaze.Oblubeny.Count == 0)
                                {
                                    Console.WriteLine("Nemas oblubene auta musis ich pridat");
                                    break;
                                }
                                else
                                {

                                    garaze.VypisOblubene();


                                    Console.Write("Pre vratenie sa na hlavnu ponuku stlacte Enter: ");
                                    var dhcpo = Console.ReadLine();
                                    switch (dhcpo)
                                    {
                                        case " ":

                                            break;

                                    }
                                    break;
                                }
                            case "4": //Kupovanie Auta
                                Console.Clear();
                                Menu();
                                Console.WriteLine("1. Prezeranie vsetkych Aut");
                                Console.WriteLine("2. Prezeranie oblubenych Aut");
                                Console.WriteLine(" ");
                                Console.Write("Vyberte z kadial chcete auta kupovat: ");
                                var dhcpu = Console.ReadLine();
                                switch (dhcpu)
                                {
                                    case "1":
                                        Console.Clear();
                                        Menu();
                                        garaze.VypisVsetkyAuta();
                                        Console.WriteLine();

                                        Console.Write("Vyber Auto na kupovania: ");
                                        int indexAuta = int.Parse(Console.ReadLine());
                                        garaze.VypocitajCenuPredaju(indexAuta);
                                        garaze.OdstranjAuto(indexAuta);
                                        Thread.Sleep(1000);
                                        Console.Clear();
                                        break;

                                    case "2":
                                        Console.Clear();
                                        Menu();
                                        garaze.VypisOblubene();

                                        if (garaze.Oblubeny.Count == 0)
                                        {
                                            Console.WriteLine("Nemas oblubene auta musis ich pridat");
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Vyber Auto na kupovania:");
                                            int indexoblu = int.Parse(Console.ReadLine());
                                            garaze.VypocitajCenuPredaju(indexoblu);
                                            garaze.OdstranjOblubeneAuto(indexoblu);
                                            
                                            Thread.Sleep(1000);
                                            Console.Clear();
                                        }
                                        break;
                                }
                                break;

                            case "5": //Harakiri aplikacie
                                isEnd = true;
                                Console.WriteLine("");
                                Console.WriteLine("Dakujeme za pouzivanie applikacie. Dufam za sa vratite");
                                return;

                            case "7":
                                Console.Clear();
                                Menu();
                                Console.Write("Zadaj Prihlasovacie meno: ");
                                var zadavaniemena12 = Console.ReadLine();
                                Console.WriteLine("  ");
                                Console.Write("Zadaj Heslo: ");
                                var zadaniehesla12 = Console.ReadLine();
                                Console.WriteLine("  ");

                                var meno1 = "Jan";
                                var men01 = "Jakub";
                                var heslo1 = "Heslo123";
                                var hesl01 = "HesloHeslo";
                                var menosecret1 = "Mato";
                                var heslosecret1 = "Automaty<3";

                                if (zadavaniemena12 == meno1 && zadaniehesla12 == heslo1)
                                {
                                    Console.Clear();
                                    Menu();

                                }
                                else if (zadavaniemena12 == men01 && zadaniehesla12 == hesl01)
                                {
                                    Console.Clear();
                                    Menu();

                                }
                                else if (zadavaniemena12 == menosecret1 && zadaniehesla12 == heslosecret1)
                                {
                                    Console.Clear();
                                    Menu();

                                }
                                else
                                {
                                    Console.WriteLine("Nespravne meno alebo heslo");
                                    break;
                                }
                                Console.Clear();
                                Menu();
                                garaze.VypisVsetkyAuta();
                                Console.WriteLine();

                                Console.Write("Vyber Auto na Odtranenie: ");
                                int indexauto = int.Parse(Console.ReadLine());
                                garaze.OdstranjAuto(indexauto);
                                Thread.Sleep(1000);
                                Console.Clear();
                                break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Nesprávne meno alebo heslo. Skús to znova.");
                    Thread.Sleep(1500);
                    Console.Clear();
                }
            }
        }
        public static void VypisInfo()  //Dev Lobby
        {
            Thread.Sleep(1500);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("    ___        __         ____");
            Console.WriteLine("   /   | __ __/ /______  / __ )____ _____  ____ ______");
            Console.WriteLine("  / /| |/ / / / __/ __ |/ __  / __  /_   / __  / ___/");
            Console.WriteLine(" / ___ / /_/ / /_/ /_/ / /_/ / /_/ /  / /_/_/ / /");
            Console.WriteLine("/_/  |_|__._/|__/|___/_____/ |__,_/  /___/|__/_/");
            Console.WriteLine("------------------------------------------------------- ");
            Console.WriteLine("  |  _. ._     _.     |  _. |      |_   ");
            Console.WriteLine("\\_| (_| | |   (_|   \\_| (_| |< |_| |_) ");
            Console.WriteLine("----------------------------------------- ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("------- Developer Ucet ---------");
            Console.WriteLine("1. Pridanie Auta");
            Console.WriteLine("2. Prezeranie Aut");
            Console.WriteLine("3. Oblubene Auta");
            Console.WriteLine("4. Kupovanie Auta");
            Console.WriteLine("5. Vypnut");
            Console.WriteLine("6. Odhlasit sa");
            Console.WriteLine("7. Odstranit Auto");
            Console.WriteLine("  ");
            Console.WriteLine("Vyberte akciu   ");
        }
        public static void Menu()  //Menu Lobby
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("    ___        __         ____");
            Console.WriteLine("   /   | __ __/ /______  / __ )____ _____  ____ ______");
            Console.WriteLine("  / /| |/ / / / __/ __ |/ __  / __  /_   / __  / ___/");
            Console.WriteLine(" / ___ / /_/ / /_/ /_/ / /_/ / /_/ /  / /_/_/ / /");
            Console.WriteLine("/_/  |_|__._/|__/|___/_____/ |__,_/  /___/|__/_/");
            Console.WriteLine("------------------------------------------------------- ");
            Console.WriteLine("  |  _. ._     _.     |  _. |      |_   ");
            Console.WriteLine("\\_| (_| | |   (_|   \\_| (_| |< |_| |_) ");
            Console.WriteLine("----------------------------------------- ");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void Host()  //Host Lobby
        {
            Thread.Sleep(1500);
            Console.Clear();
            Menu();
            Console.WriteLine("------- Host Ucet ---------");
            Console.WriteLine("1. Prezeranie Aut");
            Console.WriteLine("2. Oblubene Auta");
            Console.WriteLine("3. Kupovanie Auta");
            Console.WriteLine("4. Vypnut");
            Console.WriteLine("5. Odhlasit sa");
            Console.WriteLine("  ");
            Console.WriteLine("Vyberte akciu   ");
        }
        public static void Admin()  //Adminove Lobby
        {
            Thread.Sleep(1500);
            Console.Clear();
            Menu();
            Console.WriteLine("------- Admin Ucet ---------");
            Console.WriteLine("1. Pridanie Auta");
            Console.WriteLine("2. Prezeranie Aut");
            Console.WriteLine("3. Oblubene Auta");
            Console.WriteLine("4. Vypnut");
            Console.WriteLine("5. Odhlasit sa");
            Console.WriteLine("6. Odstranit Auto");
            Console.WriteLine("  ");
            Console.WriteLine("Vyberte akciu   ");
        }
    }
}