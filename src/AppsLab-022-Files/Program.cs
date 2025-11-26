
class program
{
    static void Main()
    {
        // Cesta k súboru – môžeš si ju zmeniť podľa seba
        string filename = @"C:\Users\NTB\OneDrive\Počítač\prax.txt";

        Console.WriteLine("Píš text. Keď chceš skončiť, napíš 'koniec'.");

        while (true)
        {
            // Načíta riadok z klávesnice
            string text = Console.ReadLine();
            File.AppendAllText(filename, text);

            // Ak napíšem "koniec", program sa ukončí
            if (text.ToLower() == "koniec")
            {
                Console.WriteLine("Program skončil.");
                break;
            }

            // Zapíše text do súboru a pridá nový riadok
            File.AppendAllText(filename, text + Environment.NewLine);
        }
    }
}