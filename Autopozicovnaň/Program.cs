namespace Autopozicovna
{
    class Program
    {
        static void Main(string[] args)
        {
            // Vytvorenie aut
            var sportoveAuto = new SportoveAuto("Ferrari", "480", 200m, 330, 3.0);
            var velkeAuto = new VelkeAuto("Ford" ,"Transit", 80m, 8, 500);
            var elektrickeAuto = new ElektrickeAuto("Tesla", "Model 3", 150m, 75, 500);

            // Vytvorenie autopozicovne a pridanie aut
            var pozicovna = new Pozicovna();
            pozicovna.PridajAuto(sportoveAuto);
            pozicovna.PridajAuto(velkeAuto);
            pozicovna.PridajAuto(elektrickeAuto);

            // Vypis vsetkych aut
            pozicovna.VypisVsetkyAut();

            // Vypocet ceny prenajmu
            Console.Write("Zadajte cislo auta (1, 2, 3): ");
            int cisloAuta = int.Parse(Console.ReadLine());
            Console.Write("Zadajte počet dní na prenájom: ");
            int dni = int.Parse(Console.ReadLine());
            var cena = pozicovna.VypocitajCenuPrenajmu(cisloAuta, dni);

            if (cena.HasValue)
            {
                Console.WriteLine($"Celkova cena prenajmu: {cena.Value}");
            }
        }
    }
}