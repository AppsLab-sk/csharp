using generator;



Engine engine = new Engine();
Console.WriteLine("Pokracuj stlacenim klavesy");
while (Console.ReadKey(true).Key != ConsoleKey.Escape)
{ 

 Fileprovider myFileprovider = new Fileprovider();
    int maxNumber = myFileprovider.LoadMaxNumber("C:\\Users\\kubiszr25\\cislo\\cislo.txt");
    Randomizer myRandomizer = new Randomizer(maxNumber);

    int randomNumber = myRandomizer.Random();
    engine.Do(randomNumber);
    Console.WriteLine("pokracuj stlacenim klavesy, ESC ukoncis program");
}
