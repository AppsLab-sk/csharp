namespace Autopožičovňa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Definicia Aut
            Pozicovna pozicovna = new Pozicovna();
            SportoveAuto sportiak = new SportoveAuto(znacka: "McLaren", model: "Coupe ", cenazaden: 500, maxrychlost: 330, zrychlenie: 2.0);
            VelkeAuto terenak = new VelkeAuto(znacka: "Toyota", model: "Highlander ", cenazaden: 90, kapacitapasazierov: 7, objembatozinu: 500);
            ElektrickeAuto baterkac = new ElektrickeAuto(znacka: "Tesla", model: "Model S ", cenazaden: 120, kapacitabaterie: 100, dojazdnanabitie: 400);

            //Priradenie Aut
            pozicovna.PridajAuto(sportiak);
            pozicovna.PridajAuto(terenak);
            pozicovna.PridajAuto(baterkac);

            //Vypis Aut
            pozicovna.VypisVsetkyAuta();

            //Zvolenie si Auta
            Console.WriteLine();
            Console.WriteLine("Vyber Auto na pozicanie :");
            int indexAuta = int.Parse(Console.ReadLine());
            Console.WriteLine("A na kolko dni :");
            int dni = int.Parse(Console.ReadLine());

            //Vypocitanie ceny
            pozicovna.VypocitajCenuPrenajmu(indexAuta, dni);
        }
    }
}