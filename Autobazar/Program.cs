using static System.Formats.Asn1.AsnWriter;

namespace AutoBazar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> auticka = new List<string>();
            bool isEnd = false;

            while (!isEnd)
            {
                VypisInfo();
                var akcia = Console.ReadLine();

                switch (akcia)
                {
                    case "1": // pridavanie Aut
                        Console.Clear();
                        Menu();
                        Console.WriteLine("Zadaj Prihlasovacie meno");
                        var zadavaniemena = Console.ReadLine();
                        Console.WriteLine("  ");
                        Console.WriteLine("Zadaj Heslo");
                        var zadaniehesla = Console.ReadLine();
                        Console.WriteLine("  ");

                        var meno = "Jan";
                        var men0 = "Jakub";
                        var heslo = "Heslo123";
                        var hesl0 = "HesloHeslo";


                        if (zadavaniemena == meno && zadaniehesla == heslo)
                        {
                            Console.Clear();
                            Menu();

                        }
                        else if (zadavaniemena == men0 && zadaniehesla == hesl0)
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
                        Console.WriteLine("Objem batozinoveho prietoru Auta");
                        var batozina = Console.ReadLine();
                        Console.WriteLine("----------------------------------------- ");
                        Console.WriteLine("Opis");
                        var opis = Console.ReadLine();
                        Console.WriteLine("----------------------------------------- ");
                        AddCar(auticka, znacka, model, Int32.Parse(cena), double.Parse(spotreba), Int32.Parse(pasaziery), Int32.Parse(batozina), opis);
                        break;

                    case "2": // Prezeranie Aut

                        Console.Clear();
                        Menu();
                        foreach (var caros in auticka)
                        {
                            Console.WriteLine(caros);
                            Console.WriteLine("----------------------------------------- ");

                        }
                        Thread.Sleep(1000);

                        break;
                    case "3": //Oblubene Auta
                        Console.Clear();
                        Menu();
                        Console.WriteLine("Eror 404 Akcia neplatna");

                        break;
                    case "4": //Kupovanie Auta
                        Console.Clear();
                        Menu();
                        Console.WriteLine("Eror 404 Akcia neplatna");

                        break;

                    case "5": //Harakiri aplikacie
                        isEnd = true;
                        Console.WriteLine("");
                        Console.WriteLine("Dakujeme za pouzivanie applikacie. Dufam za sa vratite");
                        break;

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
        public static void AddCar(List<string> carList, string znacka1, string model1, int cena1, double spotreba1, int batozina1, int pasaziery1, string opis1)
        {
            string foundedCar = null;
            foreach (var car in carList)
            {
                if (car.Contains(znacka1))
                {
                    foundedCar = car;

                }
            }

            if (foundedCar == null)
            {
                var newCreatedCar = $"Auto {znacka1}  {model1} za {cena1} ma spotrebu {spotreba1} velkost batozinoveho priestoru je {batozina1} pasaziery {pasaziery1} Opis: {opis1}";
                carList.Add(newCreatedCar);
                Console.WriteLine($"Predmet {znacka1.ToUpper()} bol pridany do aplikacie.");
            }
        }
    }
}
