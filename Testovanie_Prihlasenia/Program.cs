namespace Testovanie_Prihlasenia
{  
        internal class Program
        {
            static void Main(string[] args)
            {
                bool isEnd = false;
                while (true) // Prihlasaovaci system 2.0
                {
                    //Dialog komunikacie 
                    Menu();
                    Console.WriteLine("Zadaj Prihlasovacie meno");
                    var zadavaniemena = Console.ReadLine();
                    Console.WriteLine("  ");
                    Console.WriteLine("Zadaj Heslo");
                    var zadaniehesla = Console.ReadLine();
                    Console.WriteLine("  ");

                    //Hesla
                    var host = "Host";
                    var hheslo = "Host";
                    var admin = "Admin";
                    var aheslo = "Admin";
                    var dev = "Dev";
                    var dheslo = "Dev";

                    if (host == zadavaniemena && hheslo == zadaniehesla)
                    {

                        Console.WriteLine("Vitaj uzivatel");

                        Host();
                        while (!isEnd)
                        {
                            var akcia = Console.ReadLine();

                            switch (akcia)
                            {
                                case "1": // Prezeranie Aut
                                    Console.Clear();
                                    Menu();
                                    Console.WriteLine("Eror 404 Akcia neplatna");

                                    break;
                                case "2": // Oblubene Auta
                                    Console.Clear();
                                    Menu();
                                    Console.WriteLine("Eror 404 Akcia neplatna");
                                    break;
                                case "3": // Kupovanie Aut
                                    Console.Clear();
                                    Menu();
                                    Console.WriteLine("Eror 404 Akcia neplatna");

                                    break;

                                case "4": // Exit
                                    isEnd = true;
                                    Console.WriteLine("");
                                    Console.WriteLine("Dakujeme za pouzivanie applikacie. Dufam za sa vratite");
                                    break;

                            }
                        }

                        break;

                    }
                    else if (admin == zadavaniemena && aheslo == zadaniehesla)
                    {
                        Console.WriteLine("Vitaj administrator");

                        Admin();
                        while (!isEnd)
                        {
                            var akcia = Console.ReadLine();

                            switch (akcia)
                            {
                                case "1": // Pridavanie Aut
                                    Console.Clear();
                                    Menu();
                                    Console.WriteLine("Zadaj Prihlasovacie meno");
                                    var zadavaniemena1 = Console.ReadLine();
                                    Console.WriteLine("  ");
                                    Console.WriteLine("Zadaj Heslo");
                                    var zadaniehesla2 = Console.ReadLine();
                                    Console.WriteLine("  ");

                                    var meno = "Jan";
                                    var men0 = "Jakub";
                                    var heslo = "Heslo123";
                                    var hesl0 = "HesloHeslo";


                                    if (zadavaniemena1 == meno && zadaniehesla2 == heslo)
                                    {
                                        Console.Clear();
                                        Menu();
                                        Priadavacia();
                                    }
                                    else if (zadavaniemena1 == men0 && zadaniehesla2 == hesl0)
                                    {
                                        Console.Clear();
                                        Menu();
                                        Priadavacia();
                                    }
                                    else
                                    {
                                        Console.WriteLine("Nespravne meno alebo heslo");
                                    }
                                    break;

                                case "2": // Prezeranie Aut
                                    Console.Clear();
                                    Menu();
                                    Console.WriteLine("Eror 404 Akcia neplatna");

                                    break;
                                case "3": // Oblubene Auta
                                    Console.Clear();
                                    Menu();
                                    Console.WriteLine("Eror 404 Akcia neplatna");

                                    break;
                                case "4": // Exit
                                    isEnd = true;
                                    Console.WriteLine("");
                                    Console.WriteLine("Dakujeme za pouzivanie applikacie. Dufam za sa vratite");
                                    break;

                            }
                        }
                        break;


                    }
                    else if (dev == zadavaniemena && dheslo == zadaniehesla)
                    {
                        Console.WriteLine("Vitaj Developer");
                        VypisInfo();
                        while (!isEnd)
                        {
                            var akcia = Console.ReadLine();

                            switch (akcia)
                            {
                                case "1": // Kupovanie Aut
                                Console.Clear();
                                Menu();
                                Console.WriteLine("Zadaj Prihlasovacie meno");
                                var zadavaniemena1 = Console.ReadLine();
                                Console.WriteLine("  ");
                                Console.WriteLine("Zadaj Heslo");
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
                                else if (zadavaniemena1 == men0 && zadaniehesla1 == hesl0)
                                {
                                    Console.Clear();
                                    Menu();

                                }
                                else if (zadavaniemena1 == menosecret && zadaniehesla1 == heslosecret)
                                {
                                    Console.Clear();
                                    Menu();

                                }
                                else
                                {
                                    Console.WriteLine("Nespravne meno alebo heslo");
                                    break;
                                }
                                
                                Console.WriteLine("Znacka Aut");
                                var znacka = Console.ReadLine();
                                Console.WriteLine("----------------------------------------- ");
                                Console.WriteLine("Model Auta");
                                var model = Console.ReadLine();
                                Console.WriteLine("----------------------------------------- ");
                                Console.WriteLine("Cena Auta");
                                var cena = Console.ReadLine();
                                Console.WriteLine("----------------------------------------- ");
                                Console.WriteLine("Spotreba Auta");
                                var spotreba = Console.ReadLine();
                                Console.WriteLine("----------------------------------------- ");
                                Console.WriteLine("Pocet pasazierov");
                                var pasaziery = Console.ReadLine();
                                Console.WriteLine("----------------------------------------- ");
                                Console.WriteLine("Objem botozinoveho prietoru Auta");
                                var batozina = Console.ReadLine();
                                Console.WriteLine("----------------------------------------- ");
                                Console.WriteLine("Opis");
                                var opis = Console.ReadLine();
                                Console.WriteLine("----------------------------------------- ");
                             
                               break;

                            case "2": // Prezeranie Aut
                                    Console.Clear();
                                    Menu();
                                    Console.WriteLine("Eror 404 Akcia neplatna");

                                    break;
                                case "3": // Oblubene Auta
                                    Console.Clear();
                                    Menu();
                                    Console.WriteLine("Eror 404 Akcia neplatna");

                                    break;
                                case "4": // Kupovanie Auta
                                    Console.Clear();
                                    Menu();
                                    Console.WriteLine("Eror 404 Akcia neplatna");

                                    break;

                                case "5": // Exit ukoncenie
                                    isEnd = true;
                                    Console.WriteLine("");
                                    Console.WriteLine("Dakujeme za pouzivanie applikacie. Dufam za sa vratite");
                                    break;
                                case "6":
                                    isEnd = false;
                                    break;

                            }

                        }
                    }
                    else // nespavnne heslo 
                    {
                        Console.WriteLine("Nespravne meno alebo heslo. Skus to znova");
                        Thread.Sleep(1250);
                        Console.Clear();
                    }
                }

            }
            public static void VypisInfo()
            {
                Thread.Sleep(1500);
                Console.Clear();
                Console.WriteLine("    ___        __         ____");
                Console.WriteLine("   /   | __ __/ /______  / __ )____ _____  ____ ______");
                Console.WriteLine("  / /| |/ / / / __/ __ |/ __  / __  /_   / __  / ___/");
                Console.WriteLine(" / ___ / /_/ / /_/ /_/ / /_/ / /_/ /  / /_/_/ / /");
                Console.WriteLine("/_/  |_|__._/|__/|___/_____/ |__,_/  /___/|__/_/");
                Console.WriteLine("------------------------------------------------------- ");
                Console.WriteLine("  |  _. ._     _.     |  _. |      |_   ");
                Console.WriteLine("\\_| (_| | |   (_|   \\_| (_| |< |_| |_) ");
                Console.WriteLine("----------------------------------------- ");
                Console.WriteLine("1. Pridanie Auta");
                Console.WriteLine("2. Prezeranie Aut");
                Console.WriteLine("3. Oblubene Auta");
                Console.WriteLine("4. Kupovanie Auta");
                Console.WriteLine("5. Exit");
                Console.WriteLine("  ");
                Console.WriteLine("Vyberte akciu   ");
            }
            public static void Menu()
            {
                Console.WriteLine("    ___        __         ____");
                Console.WriteLine("   /   | __ __/ /______  / __ )____ _____  ____ ______");
                Console.WriteLine("  / /| |/ / / / __/ __ |/ __  / __  /_   / __  / ___/");
                Console.WriteLine(" / ___ / /_/ / /_/ /_/ / /_/ / /_/ /  / /_/_/ / /");
                Console.WriteLine("/_/  |_|__._/|__/|___/_____/ |__,_/  /___/|__/_/");
                Console.WriteLine("------------------------------------------------------- ");
                Console.WriteLine("  |  _. ._     _.     |  _. |      |_   ");
                Console.WriteLine("\\_| (_| | |   (_|   \\_| (_| |< |_| |_) ");
                Console.WriteLine("----------------------------------------- ");
            }
            public static void Priadavacia()
            {
                Console.WriteLine("Znacka Aut");
                var znacka = Console.ReadLine();
                Console.WriteLine("----------------------------------------- ");
                Console.WriteLine("Model Auta");
                var model = Console.ReadLine();
                Console.WriteLine("----------------------------------------- ");
                Console.WriteLine("Cena Auta");
                var cena = Console.ReadLine();
                Console.WriteLine("----------------------------------------- ");
                Console.WriteLine("Spotreba Auta");
                var spotreba = Console.ReadLine();
                Console.WriteLine("----------------------------------------- ");
                Console.WriteLine("Pocet pasazierov");
                var pasaziery = Console.ReadLine();
                Console.WriteLine("----------------------------------------- ");
                Console.WriteLine("Objem botozinoveho prietoru Auta");
                var batozina = Console.ReadLine();
                Console.WriteLine("----------------------------------------- ");
                Console.WriteLine("Opis");
                var opis = Console.ReadLine();
                Console.WriteLine("----------------------------------------- ");

                Console.WriteLine(" Auto " + znacka + " " + model + " Cena " + cena + " Spotreba " + spotreba + " Batozinovy priestor " + pasaziery + " Opis " + opis);
                Thread.Sleep(3500);
            }
            public static void Host()
            {
                Thread.Sleep(1500);
                Console.Clear();
                Menu();
                Console.WriteLine("1. Prezeranie Aut");
                Console.WriteLine("2. Oblubene Auta");
                Console.WriteLine("3. Kupovanie Auta");
                Console.WriteLine("4. Exit");
                Console.WriteLine("  ");
                Console.WriteLine("Vyberte akciu   ");
            }
            public static void Admin()
            {
                Thread.Sleep(1500);
                Console.Clear();
                Menu();
                Console.WriteLine("1. Pridanie Auta");
                Console.WriteLine("2. Prezeranie Aut");
                Console.WriteLine("3. Oblubene Auta");
                Console.WriteLine("4. Exit");
                Console.WriteLine("  ");
                Console.WriteLine("Vyberte akciu   ");
            }





        }
    }
