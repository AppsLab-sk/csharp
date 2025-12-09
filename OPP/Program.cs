using OPP;

WordReader wordReader = new();
int numberOfWords = wordReader.CountWords();
Console.WriteLine($"Počet slov: {numberOfWords}");