using Autopozicovna;

class Program
{
    static void Main(string[] args)
    {
        // Vytvorenie áut
        var sportoveAuto = new Sportoveauto("Ferrari", "488", 200m, 330, 3.0);
        var velkeAuto = new Velkeauto("Ford", "Transit", 80m, 8, 500);
        var elektrickeAuto = new Elektrickeauto("Tesla", "Model 3", 150m, 75, 500);

        // Vytvorenie autopožičovne a pridanie áut
        var pozicovna = new Pozicovna();
        pozicovna.PridajAuto(sportoveAuto);
        pozicovna.PridajAuto(velkeAuto);
        pozicovna.PridajAuto(elektrickeAuto);

        // Vypis všetkých áut
        pozicovna.VypisVsetkyAut();

        // Vypocet ceny prenajmu
        Console.Write("Zadajte cislo auta (1, 2, 3): ");
        int indexAuto = int.Parse(Console.ReadLine()) - 1;
        Console.Write("Zadajte počet dní na prenájom: ");
        int dni = int.Parse(Console.ReadLine());
        var cena = pozicovna.VypocitajCenuPrenajmu(indexAuto, dni);

        if (cena.HasValue)
        {
            Console.WriteLine($"Celková cena prenájmu: {cena.Value}€");
        }
    }
}
