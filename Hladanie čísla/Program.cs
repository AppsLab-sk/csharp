using Hladanie_čísla;
Engine engine = new Engine();
Console.WriteLine("pokracuj stlacenim klavesy");

while (Console.ReadKey(true).Key != ConsoleKey.Escape)
{
    FileProvider myFileProvider = new FileProvider();
    int maxNumber = myFileProvider.LoadMaxNumber("C:\\Users\\cvengrosm25\\Cisla\\cislo.txt");
    Randomizer myRandomizer = new Randomizer(maxNumber);
    int randomNumber = myRandomizer.Random();

    engine.Do(randomNumber);
    Console.WriteLine("Výborne zvladol si to...pokracuj stlacenim klavesy, ESC ukoncis program");

}