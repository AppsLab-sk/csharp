using AppsLab_018_Methods;

var exercise = new Exercise();

// Inštrukcie pre ukončenie aplikácie
Console.WriteLine("Pre ukončenie aplikácie zadajte 'quit'");

// Neustále načítavajte vstup a vypíšte výsledok metódy FizzBuzz
while (true)
{
    Console.Write("Zadajte číslo: ");
    string? input = Console.ReadLine();

    // Pre ukončenie programu môže používateľ zadať 'quit'
    if (input?.ToLower() == "quit")
    {
        break;
    }

    // Je vstup platné číslo?
    if (int.TryParse(input, out int number))
    {
        // Zavolajte metódu FizzBuzz a vypíšte výsledok
        string result = exercise.FizzBuzz(number);
        Console.WriteLine($"Výsledok: {result}");
    }
    else
    {
        Console.WriteLine("Neplatné číslo. Skúste to znova.");
    }
}