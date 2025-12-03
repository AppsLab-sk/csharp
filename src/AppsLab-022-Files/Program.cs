string filename = "C:\\Users\\smrzo\\Documents\\projekty VisualStudio\\nacitanie textu.txt";

Console.WriteLine(File.ReadAllText(filename));
while (true)
{
    Console.WriteLine("zadaj text alebo napis koniec pre ukoncenie programu");
    string input = Console.ReadLine();
    Console.ReadKey();
    if (input.ToLower() == "koniec")
    {
        Console.WriteLine("ukonil si program");
        break;
    }
    File.AppendAllText(filename, input + " \n");
}

