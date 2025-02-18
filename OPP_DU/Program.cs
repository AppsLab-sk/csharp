namespace OPP_DU
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pozicanieauta pozicovna = new Pozicanieauta();

            Sauto sportoveAuto = new Sauto("Mercedes-Benz", "clasaA", 120, 430, 5);
            Eauto elektrickeAuto = new Eauto("Audi", "8Q", 300, 420, 6);

            pozicovna.PridajAuto(sportoveAuto);
            pozicovna.PridajAuto(elektrickeAuto);

            Console.WriteLine("Zoznam všetkých áut v požičovni, kt. su aktualne:");
            pozicovna.VypisVsetkyAuta();


            Console.Write("Zadajte index auta,kt. potrebujete prenajať: ");
            int index = int.Parse(Console.ReadLine());
            Console.Write("Na kolko dni si chces prenajať auto: ");
            int dni = int.Parse(Console.ReadLine());

            int cena = pozicovna.VypocitajCenuPrenajmu(index, dni);
            if (cena!=null)
            {
                Console.WriteLine($"Cena za prenájom: {cena} €");
            }
            else
            {
                Console.WriteLine("Neznami index auta.");
            }
        }

    }
}
