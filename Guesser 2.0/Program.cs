    using Guesser_2._0;
Engine engine = new Engine();
Console.WriteLine("pokracuj stlacenim klaesy");

while (Console.ReadKey(true).Key != ConsoleKey.Escape)
{
    
    FileProvider fileProvider = new FileProvider();
    int maxNumber = fileProvider.LoadMaxNumber("C:\\Users\\mahutm25\\Mause\\txt.txt");
    Randomizer randomizer = new Randomizer(maxNumber);
    int randomNumber = randomizer.Random();

    engine.Do(randomNumber);
    Console.WriteLine("You won!!!! continue or press ESC to end");




}
