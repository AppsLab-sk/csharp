using uhadni;

Engine engine = new Engine();
Console.WriteLine("pokracuj stlacenim klavesi");

while (Console.ReadKey(true).Key != ConsoleKey.Escape)
{

    FileProvider myFileProvider = new FileProvider();

    int maxNumber = myFileProvider.LoadMaxNumber("C:\\Users\\NTB\\OneDrive\\Dokumenty\\prax\\numberguess.txt");
    Randomizer myRandomizer = new Randomizer(maxNumber);
    int randomNumber = myRandomizer.Random();

   

    engine.Do(randomNumber);
    Console.WriteLine("pokracuj stlacenim klavesiy , ESC ukončíš program");
}
